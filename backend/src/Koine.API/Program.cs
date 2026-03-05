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

var builder = WebApplication.CreateBuilder(args);

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
builder.Services.AddScoped<Koine.Application.Study.Services.StudySessionService>();
builder.Services.AddScoped<Koine.Application.Study.Ports.ICurrentUserProvider, Koine.API.Providers.HttpContextCurrentUserProvider>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IUserCardProgressRepository, Koine.Infrastructure.Study.Repositories.UserCardProgressRepository>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IStudySessionRepository, Koine.Infrastructure.Study.Repositories.StudySessionRepository>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IVocabularyRepository, Koine.Infrastructure.Study.Repositories.StudyVocabularyRepository>();
builder.Services.AddScoped<Koine.Application.Study.Ports.IVocabularySetItemRepository, Koine.Infrastructure.Study.Repositories.StudyVocabularySetItemRepository>();

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
