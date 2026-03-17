using System.Reflection;
using System.Security.Claims;
using Koine.Application.Study.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;

namespace Koine.Tests.Integration;

[TestFixture]
public class ApiEndpointSmokeTests
{
    [Test]
    public async Task All_Controller_Endpoints_Are_Smoke_Invocable()
    {
        var endpoints = DiscoverEndpointMethods().ToList();
        Assert.That(endpoints, Is.Not.Empty, "No endpoint methods were discovered.");

        var failures = new List<string>();
        foreach (var endpoint in endpoints)
        {
            try
            {
                await InvokeEndpointAsync(endpoint);
            }
            catch (Exception ex)
            {
                var actual = ex is TargetInvocationException tie && tie.InnerException != null
                    ? tie.InnerException
                    : ex;
                failures.Add(
                    $"{endpoint.Controller.Name}.{endpoint.Method.Name}: {actual.GetType().Name} - {actual.Message}");
            }
        }

        if (failures.Count > 0)
        {
            Assert.Fail(
                $"Endpoint smoke failures: {failures.Count}/{endpoints.Count}{Environment.NewLine}{string.Join(Environment.NewLine, failures)}");
        }
    }

    private static IEnumerable<(Type Controller, MethodInfo Method)> DiscoverEndpointMethods()
    {
        var apiAssembly = typeof(Koine.API.Controllers.ReaderController).Assembly;
        var controllers = apiAssembly.GetTypes()
            .Where(t => typeof(ControllerBase).IsAssignableFrom(t))
            .Where(t => t is { IsAbstract: false, IsPublic: true })
            .Where(t => string.Equals(t.Namespace, "Koine.API.Controllers", StringComparison.Ordinal))
            .OrderBy(t => t.Name);

        foreach (var controller in controllers)
        {
            var methods = controller.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Where(m => m.CustomAttributes.Any(a => typeof(HttpMethodAttribute).IsAssignableFrom(a.AttributeType)))
                .OrderBy(m => m.Name);

            foreach (var method in methods)
            {
                yield return (controller, method);
            }
        }
    }

    private static async Task InvokeEndpointAsync((Type Controller, MethodInfo Method) endpoint)
    {
        var controller = (ControllerBase)CreateWithDependencies(endpoint.Controller);
        controller.ControllerContext = new ControllerContext
        {
            HttpContext = BuildHttpContext(),
        };

        var args = endpoint.Method.GetParameters()
            .Select(p => CreateValue(p.ParameterType, 0))
            .ToArray();

        var invocationResult = endpoint.Method.Invoke(controller, args);
        var result = await UnwrapAsyncResult(invocationResult, endpoint.Method.ReturnType);
        Assert.That(result, Is.Not.Null, $"{endpoint.Controller.Name}.{endpoint.Method.Name} returned null.");
    }

    private static HttpContext BuildHttpContext()
    {
        var ctx = new DefaultHttpContext();
        ctx.Request.Headers["X-Dev-User-Id"] = "1";
        var identity = new ClaimsIdentity(
            [new Claim(ClaimTypes.NameIdentifier, "1")],
            "Smoke");
        ctx.User = new ClaimsPrincipal(identity);
        return ctx;
    }

    private static async Task<object?> UnwrapAsyncResult(object? invocationResult, Type returnType)
    {
        if (invocationResult == null)
        {
            return null;
        }

        if (returnType == typeof(Task))
        {
            await (Task)invocationResult;
            return new object();
        }

        if (typeof(Task).IsAssignableFrom(returnType))
        {
            var task = (Task)invocationResult;
            await task;
            return returnType.GetProperty("Result")?.GetValue(invocationResult);
        }

        return invocationResult;
    }

    private static object CreateWithDependencies(Type type)
    {
        var constructor = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
            .OrderByDescending(c => c.GetParameters().Length)
            .FirstOrDefault();

        if (constructor == null)
        {
            return Activator.CreateInstance(type)
                   ?? throw new InvalidOperationException($"Could not create instance of {type.Name}");
        }

        var parameters = constructor.GetParameters()
            .Select(p => ResolveDependency(p.ParameterType))
            .ToArray();

        return constructor.Invoke(parameters);
    }

    private static object ResolveDependency(Type dependencyType)
    {
        if (dependencyType == typeof(IConfiguration))
        {
            return new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string?>
                {
                    ["DevSettings:DefaultTestUser"] = "beginner",
                })
                .Build();
        }

        if (dependencyType.IsGenericType &&
            dependencyType.GetGenericTypeDefinition() == typeof(ILogger<>))
        {
            var loggerType = dependencyType.GetGenericArguments()[0];
            var method = typeof(ApiEndpointSmokeTests)
                .GetMethod(nameof(CreateLoggerMock), BindingFlags.Static | BindingFlags.NonPublic)!
                .MakeGenericMethod(loggerType);
            return method.Invoke(null, null)!;
        }

        if (dependencyType.IsInterface)
        {
            return CreateInterfaceProxy(dependencyType);
        }

        if (dependencyType == typeof(StudySessionService))
        {
            return CreateWithDependencies(dependencyType);
        }

        if (dependencyType.IsClass)
        {
            return CreateWithDependencies(dependencyType);
        }

        return CreateValue(dependencyType, 0)!;
    }

    private static object CreateInterfaceProxy(Type interfaceType)
    {
        var createMethod = typeof(ApiEndpointSmokeTests)
            .GetMethod(nameof(CreateTypedProxy), BindingFlags.Static | BindingFlags.NonPublic)!;
        var generic = createMethod.MakeGenericMethod(interfaceType);
        return generic.Invoke(null, null)!;
    }

    private static object CreateTypedProxy<T>() where T : class
    {
        var proxy = DispatchProxy.Create<T, SmokeInterfaceProxy<T>>();
        ((SmokeInterfaceProxy<T>)(object)proxy).SetFactory(CreateReturnValue);
        return proxy;
    }

    private static ILogger<T> CreateLoggerMock<T>() => new Mock<ILogger<T>>().Object;

    private static object? CreateReturnValue(Type returnType)
    {
        if (returnType == typeof(void))
        {
            return null;
        }

        if (returnType == typeof(Task))
        {
            return Task.CompletedTask;
        }

        if (returnType.IsGenericType && returnType.GetGenericTypeDefinition() == typeof(Task<>))
        {
            var innerType = returnType.GetGenericArguments()[0];
            var value = CreateValue(innerType, 0);
            var taskFromResult = typeof(Task)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(m => m.Name == nameof(Task.FromResult))
                .MakeGenericMethod(innerType);
            return taskFromResult.Invoke(null, [value]);
        }

        if (returnType == typeof(ValueTask))
        {
            return ValueTask.CompletedTask;
        }

        if (returnType.IsGenericType && returnType.GetGenericTypeDefinition() == typeof(ValueTask<>))
        {
            var innerType = returnType.GetGenericArguments()[0];
            var value = CreateValue(innerType, 0);
            return Activator.CreateInstance(returnType, value);
        }

        return CreateValue(returnType, 0);
    }

    private static object? CreateValue(Type type, int depth)
    {
        if (depth > 3)
        {
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }

        if (type == typeof(string))
        {
            return "smoke";
        }

        if (type == typeof(Guid))
        {
            return Guid.Parse("11111111-1111-1111-1111-111111111111");
        }

        if (type == typeof(DateTime))
        {
            return DateTime.UtcNow;
        }

        if (type == typeof(DateTimeOffset))
        {
            return DateTimeOffset.UtcNow;
        }

        if (type == typeof(bool))
        {
            return true;
        }

        if (type == typeof(int))
        {
            return 1;
        }

        if (type == typeof(long))
        {
            return 1L;
        }

        if (type == typeof(float))
        {
            return 1f;
        }

        if (type == typeof(double))
        {
            return 1d;
        }

        if (type == typeof(decimal))
        {
            return 1m;
        }

        if (type == typeof(CancellationToken))
        {
            return CancellationToken.None;
        }

        if (type.IsEnum)
        {
            return Enum.GetValues(type).GetValue(0);
        }

        var nullable = Nullable.GetUnderlyingType(type);
        if (nullable != null)
        {
            return null;
        }

        if (type.IsArray)
        {
            return Array.CreateInstance(type.GetElementType()!, 0);
        }

        if (type.IsGenericType)
        {
            var genericTypeDef = type.GetGenericTypeDefinition();
            var genericArgs = type.GetGenericArguments();
            if (genericTypeDef == typeof(List<>)
                || genericTypeDef == typeof(IList<>)
                || genericTypeDef == typeof(IEnumerable<>)
                || genericTypeDef == typeof(ICollection<>))
            {
                return Activator.CreateInstance(typeof(List<>).MakeGenericType(genericArgs[0]));
            }

            if (genericTypeDef == typeof(Dictionary<,>)
                || genericTypeDef == typeof(IDictionary<,>))
            {
                return Activator.CreateInstance(typeof(Dictionary<,>).MakeGenericType(genericArgs));
            }
        }

        if (type.IsInterface)
        {
            return CreateInterfaceProxy(type);
        }

        if (!type.IsClass)
        {
            return Activator.CreateInstance(type);
        }

        var ctor = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
            .OrderBy(c => c.GetParameters().Length)
            .FirstOrDefault();

        object? instance;
        if (ctor == null)
        {
            return null;
        }

        var ctorArgs = ctor.GetParameters()
            .Select(p => CreateValue(p.ParameterType, depth + 1))
            .ToArray();
        instance = ctor.Invoke(ctorArgs);

        foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            if (!prop.CanWrite || prop.GetIndexParameters().Length > 0)
            {
                continue;
            }

            if (prop.PropertyType == type)
            {
                continue;
            }

            try
            {
                var value = CreateValue(prop.PropertyType, depth + 1);
                if (value != null || Nullable.GetUnderlyingType(prop.PropertyType) != null || !prop.PropertyType.IsValueType)
                {
                    prop.SetValue(instance, value);
                }
            }
            catch
            {
                // Best effort for smoke payload generation.
            }
        }

        return instance;
    }

    public class SmokeInterfaceProxy<T> : DispatchProxy where T : class
    {
        private Func<Type, object?> _returnFactory = _ => null;

        public void SetFactory(Func<Type, object?> returnFactory) => _returnFactory = returnFactory;

        protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
        {
            if (targetMethod == null)
            {
                return null;
            }

            return _returnFactory(targetMethod.ReturnType);
        }
    }
}
