dotnet ef migrations add InitialCreate --project Koine.Infrastructure --startup-project Koine.API

dotnet ef database update --project Koine.Infrastructure --startup-project Koine.API
