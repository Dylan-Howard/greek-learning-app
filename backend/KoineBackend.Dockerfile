# Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy csproj files
COPY ["src/Koine.API/Koine.API.csproj", "src/Koine.API/"]
COPY ["src/Koine.Application/Koine.Application.csproj", "src/Koine.Application/"]
COPY ["src/Koine.Domain/Koine.Domain.csproj", "src/Koine.Domain/"]
COPY ["src/Koine.Infrastructure/Koine.Infrastructure.csproj", "src/Koine.Infrastructure/"]

# Restore dependencies
RUN dotnet restore "src/Koine.API/Koine.API.csproj"

# Copy everything else
COPY . .

# Build
WORKDIR "/src/src/Koine.API"
RUN dotnet build "Koine.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Koine.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Koine.API.dll"]
