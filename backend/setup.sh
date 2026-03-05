dotnet ef migrations add InitialCreate --project src/Koine.Infrastructure --startup-project src/Koine.API

dotnet ef database update --project src/Koine.Infrastructure --startup-project src/Koine.API
