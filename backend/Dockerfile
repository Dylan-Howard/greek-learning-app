FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY Koine.sln ./
COPY src/Koine.API/Koine.API.csproj src/Koine.API/
COPY src/Koine.Application/Koine.Application.csproj src/Koine.Application/
COPY src/Koine.Domain/Koine.Domain.csproj src/Koine.Domain/
COPY src/Koine.Infrastructure/Koine.Infrastructure.csproj src/Koine.Infrastructure/
COPY tests/Koine.Tests/Koine.Tests.csproj tests/Koine.Tests/

RUN dotnet restore Koine.sln

COPY . .
RUN dotnet publish src/Koine.API/Koine.API.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5001
EXPOSE 5001

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Koine.API.dll"]
