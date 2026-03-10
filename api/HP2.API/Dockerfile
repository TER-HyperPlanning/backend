FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copier les fichiers projets
COPY ["HP2.API/HP2.API.csproj", "HP2.API/"]
COPY ["HP2.Application/HP2.Application.csproj", "HP2.Application/"]
COPY ["HP2.Domain/HP2.Domain.csproj", "HP2.Domain/"]
COPY ["HP2.Infrastructure/HP2.Infrastructure.csproj", "HP2.Infrastructure/"]

# Restaurer les dépendances
RUN dotnet restore "HP2.API/HP2.API.csproj"

# Copier tout le reste
COPY . .

# Build de l'application
WORKDIR "/src/HP2.API"
RUN dotnet build "HP2.API.csproj" -c Release -o /app/build

# Publication
FROM build AS publish
RUN dotnet publish "HP2.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Image finale pour l'exécution
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HP2.API.dll"]