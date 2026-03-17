using System.Text;
using Koine.Application.DTOs.Auth;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class AuthServiceTests
{
    [Test]
    public async Task LoginAsync_ReturnsNull_WhenUserDoesNotExist()
    {
        var unitOfWork = CreateUnitOfWork(out var users, out _);
        users.Setup(r => r.GetByEmailAsync("missing@test.com")).ReturnsAsync((User?)null);
        var service = new AuthService(unitOfWork.Object, BuildJwtConfig());

        var result = await service.LoginAsync(new LoginRequestDto { Email = "missing@test.com", Password = "pw" });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task LoginAsync_ReturnsNull_WhenPasswordIsInvalid()
    {
        var unitOfWork = CreateUnitOfWork(out var users, out _);
        users.Setup(r => r.GetByEmailAsync("user@test.com")).ReturnsAsync(new User
        {
            Id = 3,
            Email = "user@test.com",
            Username = "user",
            PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes("different")),
        });

        var service = new AuthService(unitOfWork.Object, BuildJwtConfig());
        var result = await service.LoginAsync(new LoginRequestDto { Email = "user@test.com", Password = "pw" });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task LoginAsync_ReturnsTokenAndUpdatesLastLogin_WhenCredentialsAreValid()
    {
        var unitOfWork = CreateUnitOfWork(out var users, out _);
        var user = new User
        {
            Id = 4,
            Email = "user@test.com",
            Username = "user",
            PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes("pw")),
            TotalExperience = 42,
        };
        users.Setup(r => r.GetByEmailAsync("user@test.com")).ReturnsAsync(user);

        var service = new AuthService(unitOfWork.Object, BuildJwtConfig());
        var result = await service.LoginAsync(new LoginRequestDto { Email = "user@test.com", Password = "pw" });

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Token, Is.Not.Empty);
        Assert.That(result.User.Id, Is.EqualTo(4));
        users.Verify(r => r.UpdateAsync(It.Is<User>(u => u.LastLogin.HasValue)), Times.Once);
        unitOfWork.Verify(u => u.SaveChangesAsync(), Times.Once);
    }

    [Test]
    public async Task RegisterAsync_ReturnsNull_WhenEmailAlreadyExists()
    {
        var unitOfWork = CreateUnitOfWork(out var users, out var progress);
        users.Setup(r => r.GetByEmailAsync("taken@test.com")).ReturnsAsync(new User { Id = 1 });

        var service = new AuthService(unitOfWork.Object, BuildJwtConfig());
        var result = await service.RegisterAsync("taken@test.com", "newuser", "pw");

        Assert.That(result, Is.Null);
        progress.Verify(r => r.GetOrCreateByUserIdAsync(It.IsAny<int>()), Times.Never);
    }

    [Test]
    public async Task RegisterAsync_CreatesUserAndInitialProgress_WhenUnique()
    {
        var unitOfWork = CreateUnitOfWork(out var users, out var progress);
        users.Setup(r => r.GetByEmailAsync("new@test.com")).ReturnsAsync((User?)null);
        users.Setup(r => r.GetByUsernameAsync("newuser")).ReturnsAsync((User?)null);
        users.Setup(r => r.AddAsync(It.IsAny<User>()))
            .ReturnsAsync((User u) =>
            {
                u.Id = 99;
                return u;
            });
        progress.Setup(r => r.GetOrCreateByUserIdAsync(99)).ReturnsAsync(new UserProgress { UserId = 99 });

        var service = new AuthService(unitOfWork.Object, BuildJwtConfig());
        var result = await service.RegisterAsync("new@test.com", "newuser", "pw");

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Id, Is.EqualTo(99));
        users.Verify(r => r.AddAsync(It.Is<User>(u => u.Email == "new@test.com" && u.Username == "newuser")), Times.Once);
        progress.Verify(r => r.GetOrCreateByUserIdAsync(99), Times.Once);
    }

    [Test]
    public async Task GetUserFromTokenAsync_ReturnsNull_ForInvalidToken()
    {
        var unitOfWork = CreateUnitOfWork(out _, out _);
        var service = new AuthService(unitOfWork.Object, BuildJwtConfig());

        var result = await service.GetUserFromTokenAsync("not-a-jwt");

        Assert.That(result, Is.Null);
    }

    private static IConfiguration BuildJwtConfig()
    {
        return new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["JwtSettings:SecretKey"] = "YourSuperSecretKeyThatIsAtLeast32CharactersLong!",
                ["JwtSettings:Issuer"] = "KoineAPI",
                ["JwtSettings:Audience"] = "KoineClient",
            })
            .Build();
    }

    private static Mock<IUnitOfWork> CreateUnitOfWork(out Mock<IUserRepository> users, out Mock<IUserProgressRepository> progress)
    {
        users = new Mock<IUserRepository>();
        progress = new Mock<IUserProgressRepository>();

        var unitOfWork = new Mock<IUnitOfWork>();
        unitOfWork.SetupGet(u => u.Users).Returns(users.Object);
        unitOfWork.SetupGet(u => u.UserProgress).Returns(progress.Object);
        unitOfWork.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);

        return unitOfWork;
    }
}
