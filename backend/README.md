
## Run Locally
# 1. Start SQL Server (if not using Docker)
# Install SQL Server locally or use Docker for just the database
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" \
   -p 1433:1433 --name sql_server \
   -d mcr.microsoft.com/mssql/server:2022-latest

# 2. Update connection string in appsettings.Development.json

# 3. Apply migrations
dotnet ef database update --project Koine.Infrastructure --startup-project Koine.API

# 4. Run the API
cd Koine.API
dotnet run

# API will be available at http://localhost:5000
# Swagger UI at http://localhost:5000/swagger


## Run with Docker Compose

# Build and start all services
docker-compose up --build

# Or in detached mode
docker-compose up -d --build

# View logs
docker-compose logs -f api

# Stop services
docker-compose down

# Stop and remove volumes (clean slate)
docker-compose down -v

## Generate TS Types
# From the solution root
nswag run nswag.json

# This generates: frontend/src/api/generated/api-client.ts