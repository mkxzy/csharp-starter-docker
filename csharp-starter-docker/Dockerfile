#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["csharp-starter-docker/csharp-starter-docker.csproj", "csharp-starter-docker/"]
RUN dotnet restore "csharp-starter-docker/csharp-starter-docker.csproj"
COPY . .
WORKDIR "/src/csharp-starter-docker"
RUN dotnet build "csharp-starter-docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "csharp-starter-docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "csharp-starter-docker.dll"]