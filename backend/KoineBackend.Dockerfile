# Dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj files
COPY ["GreekParser.API/GreekParser.API.csproj", "GreekParser.API/"]
COPY ["GreekParser.Application/GreekParser.Application.csproj", "GreekParser.Application/"]
COPY ["GreekParser.Domain/GreekParser.Domain.csproj", "GreekParser.Domain/"]
COPY ["GreekParser.Infrastructure/GreekParser.Infrastructure.csproj", "GreekParser.Infrastructure/"]

# Restore dependencies
RUN dotnet restore "GreekParser.API/GreekParser.API.csproj"

# Copy everything else
COPY . .

# Build
WORKDIR "/src/GreekParser.API"
RUN dotnet build "GreekParser.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GreekParser.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Install EF Core tools for migrations
RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"

ENTRYPOINT ["dotnet", "GreekParser.API.dll"]
```
