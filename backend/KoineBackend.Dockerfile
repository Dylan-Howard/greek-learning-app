# Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj files
COPY ["Koine.API/Koine.API.csproj", "Koine.API/"]
COPY ["Koine.Application/Koine.Application.csproj", "Koine.Application/"]
COPY ["Koine.Domain/Koine.Domain.csproj", "Koine.Domain/"]
COPY ["Koine.Infrastructure/Koine.Infrastructure.csproj", "Koine.Infrastructure/"]

# Restore dependencies
RUN dotnet restore "Koine.API/Koine.API.csproj"

# Copy everything else
COPY . .

# Build
WORKDIR "/src/Koine.API"
RUN dotnet build "Koine.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Koine.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Koine.API.dll"]
