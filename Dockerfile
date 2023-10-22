# Utiliser l'image officielle .NET Core SDK
FROM scr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copier le fichier csproj et restaurer les dépéndances
COPY *.csproj ./
RUN dotnet restore

# Copier le reste des fichiers et construire
COPY . /
RUN dotnet publish -c Release -o out

# Générer limage de runtime
FROM scr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR//app
COPY --from=build-env /app/out .
ENTRYPOINT "dotnet","CTDAPI.dll"]