// Koine.API/Program.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Koine.Infrastructure.Data.Context;
using Koine.Infrastructure.Data;
using Koine.Application.Interfaces;
using Koine.Application.Services;
using NSwag;
using NSwag.Generation.Processors.Security;
using Microsoft.Data.SqlClient;
using System.Data;
using Koine.API.GraphQL.Schema;
using Koine.API.GraphQL.Queries;
using Koine.API.GraphQL.Mutations;
using Koine.API.GraphQL.DataLoaders;
using GraphQL;
using Koine.API.Settings;

var builder = WebApplication.CreateBuilder(args);

// --- Clerk Settings ---
// Bind ClerkSettings from configuration (ClerkSettings__* env vars or appsettings.json section).
var clerkSettings = builder.Configuration.GetSection("ClerkSettings").Get<ClerkSettings>();

if (builder.Environment.IsDevelopment())
{
    // In Development, only warn if JwksUrl is missing — do not hard-fail so the API
    // can still run without Clerk configured for pure local dev (Requirement 11.5).
    if (string.IsNullOrWhiteSpace(clerkSettings?.JwksUrl))
    {
        // Bootstrap logger: use the built-in LoggerFactory before the host is built.
        using var loggerFactory = LoggerFactory.Create(b => b.AddConsole());
        var startupLogger = loggerFactory.CreateLogger("Startup");
        startupLogger.LogWarning(
            "ClerkSettings:JwksUrl is not configured. Clerk JWT validation will not be active. " +
            "Set ClerkSettings__JwksUrl (or ClerkSettings:JwksUrl in appsettings.Development.json) " +
            "to enable Clerk authentication.");
    }
}
else
{
    // In non-Development environments all three fields are required (Requirements 12.3, 8.1–8.3).
    if (string.IsNullOrWhiteSpace(clerkSettings?.JwksUrl))
        throw new InvalidOperationException(
            "Required configuration 'ClerkSettings:JwksUrl' (env var: ClerkSettings__JwksUrl) is missing or empty. " +
            "Set it to your Clerk JWKS endpoint URL before starting the application.");

    if (string.IsNullOrWhiteSpace(clerkSettings?.Issuer))
        throw new InvalidOperationException(
            "Required configuration 'ClerkSettings:Issuer' (env var: ClerkSettings__Issuer) is missing or empty. " +
            "Set it to your Clerk Frontend API URL before starting the application.");

    if (clerkSettings?.AuthorizedParties is not { Length: > 0 })
        throw new InvalidOperationException(
            "Required configuration 'ClerkSettings:AuthorizedParties' (env var: ClerkSettings__AuthorizedParties) is missing or empty. " +
            "Set it to a comma-separated list of allowed origins before starting the application.");
}

// Add services to the container
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();

// Configure OpenAPI/Swagger with NSwag
builder.Services.AddOpenApiDocument(config =>
{
    config.DocumentName = "v1";
    config.Title = "Greek Parser API";
    config.Version = "v1";
    config.Description = "API for Greek language learning and parsing";
    
    // Add JWT authentication to Swagger
    config.AddSecurity("Bearer", new NSwag.OpenApiSecurityScheme
    {
        Type = OpenApiSecuritySchemeType.ApiKey,
        Name = "Authorization",
        In = OpenApiSecurityApiKeyLocation.Header,
        Description = "Type into the textbox: Bearer {your JWT token}."
    });

    config.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("Bearer"));
});

// Database
builder.Services.AddDbContext<KoineDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Koine.Infrastructure")
              .EnableRetryOnFailure()
    ));

// Unit of Work & Repositories
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddHttpContextAccessor();

// Application Services
builder.Services.AddScoped<IReaderService, ReaderService>();
builder.Services.AddScoped<ILessonService, LessonService>();
builder.Services.AddScoped<IProgressService, ProgressService>();
builder.Services.AddScoped<IVocabularyService, VocabularyService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IChapterService, ChapterService>();
builder.Services.AddScoped<IGrammaticalFeatureService, GrammaticalFeatureService>();
builder.Services.AddScoped<ISyntacticalFeatureService, SyntacticalFeatureService>();
builder.Services.AddScoped<ITranslationService, TranslationService>();
builder.Services.AddScoped<ITranslationUnitService, TranslationUnitService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IStudyService, StudyService>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IStudySessionService, Koine.Application.Study.Services.StudySessionService>();
builder.Services.AddScoped<Koine.Application.Study.Services.StudySessionService>();
builder.Services.AddScoped<Koine.Application.Study.Ports.ICurrentUserProvider, Koine.API.Providers.HttpContextCurrentUserProvider>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IUserCardProgressRepository, Koine.Infrastructure.Study.Repositories.UserCardProgressRepository>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IStudySessionRepository, Koine.Infrastructure.Study.Repositories.StudySessionRepository>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IVocabularyRepository, Koine.Infrastructure.Study.Repositories.StudyVocabularyRepository>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IVocabularySetItemRepository, Koine.Infrastructure.Study.Repositories.StudyVocabularySetItemRepository>();

// GraphQL — additive registrations (Requirements 1.4, 1.5, 15.4)
// RootQuery and RootMutation are scoped; KoineSchema is owned by AddGraphQL as a singleton.
// DataLoaders — scoped so each request gets its own batch context (Requirement 5.6)
builder.Services.AddScoped<ChaptersByBookIdDataLoader>();
builder.Services.AddScoped<WordsByChapterIdDataLoader>();
builder.Services.AddScoped<GrammaticalFeaturesByIdDataLoader>();
builder.Services
    .AddGraphQL(b => b
        .AddSchema<KoineSchema>(GraphQL.DI.ServiceLifetime.Scoped)
        .AddSystemTextJson()
        .AddErrorInfoProvider(opt => opt.ExposeExceptionDetails = builder.Environment.IsDevelopment())
        .AddDataLoader()
        .AddGraphTypes(typeof(KoineSchema).Assembly));

// JWT Authentication
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"] ?? throw new InvalidOperationException("JWT Secret Key not configured");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
    };
});

// Authorization policies — reuse existing JWT auth middleware (Requirements 6.1, 6.2, 6.6)
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Authenticated", policy => policy.RequireAuthenticatedUser());
    options.AddPolicy("AdminOnly", policy => policy.RequireAuthenticatedUser().RequireRole("admin"));
});

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy
            .WithOrigins(
                "http://localhost:3000", 
                "http://localhost:5173",
                "http://localhost:5174",
                "https://yourdomain.com"
            )
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi(); // Serves the OpenAPI/Swagger specification
    app.UseSwaggerUi(); // Serves the Swagger UI
}

// TODO: Re-enable HTTPS redirection in production
// app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.UseAuthentication();
app.UseAuthorization();

// GraphQL middleware — placed after auth, before MapControllers (Requirements 1.1, 1.2, 1.3, 15.4)
app.UseGraphQL<KoineSchema>("/graphql");
if (app.Environment.IsDevelopment())
{
#pragma warning disable CS0618 // UseGraphQLPlayground is obsolete but specified by the design doc
    app.UseGraphQLPlayground("/graphql/ui");
#pragma warning restore CS0618
}

app.MapControllers();

// Seed database in development
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var logger = services.GetRequiredService<ILogger<Program>>();
        try
        {
            var context = services.GetRequiredService<KoineDbContext>();

            var hasMigrations = context.Database.GetMigrations().Any();
            if (hasMigrations)
            {
                try
                {
                    await context.Database.MigrateAsync();
                }
                catch (SqlException ex) when (IsDuplicateObjectMigrationError(ex))
                {
                    logger.LogWarning(ex,
                        "Migration attempted to create existing objects; continuing with schema compatibility seeding.");
                }
                catch (Exception ex)
                {
                    logger.LogWarning(ex,
                        "Migration failed in development; rebuilding database using EnsureDeleted/EnsureCreated so seeding can continue.");
                    await RebuildDevelopmentDatabaseAsync(context, logger);
                }
            }
            else
            {
                await context.Database.EnsureCreatedAsync();
            }

            if (!await TableExistsAsync(context, "Books"))
            {
                logger.LogWarning(
                    "Table 'Books' is missing after migration/create in development; rebuilding database using EnsureDeleted/EnsureCreated.");
                await RebuildDevelopmentDatabaseAsync(context, logger);
            }

            await Koine.Infrastructure.Data.Seed.DatabaseSeeder.SeedAsync(services);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred during database initialization.");
        }
    }
}

app.Run();

static bool IsDuplicateObjectMigrationError(SqlException ex)
{
    // SQL Server 2714: "There is already an object named ... in the database."
    return ex.Number == 2714;
}

static async Task RebuildDevelopmentDatabaseAsync(KoineDbContext context, ILogger logger)
{
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();
    logger.LogInformation("Development database was rebuilt with EnsureDeleted/EnsureCreated.");
}

static async Task<bool> TableExistsAsync(KoineDbContext context, string tableName)
{
    var connection = context.Database.GetDbConnection();
    var shouldClose = connection.State != ConnectionState.Open;
    if (shouldClose)
    {
        await connection.OpenAsync();
    }

    try
    {
        await using var command = connection.CreateCommand();
        command.CommandText = "SELECT CASE WHEN OBJECT_ID(@tableName, 'U') IS NULL THEN 0 ELSE 1 END;";
        var parameter = command.CreateParameter();
        parameter.ParameterName = "@tableName";
        parameter.Value = tableName;
        command.Parameters.Add(parameter);
        var result = await command.ExecuteScalarAsync();
        return Convert.ToInt32(result) == 1;
    }
    finally
    {
        if (shouldClose)
        {
            await connection.CloseAsync();
        }
    }
}
