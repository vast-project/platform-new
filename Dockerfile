#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
# .NET 8+ base images default to ASPNETCORE_HTTP_PORTS=8080, whereas the aspnet:7.0
# image these replaced set ASPNETCORE_URLS=http://+:80. Pin it back to 80 so existing
# port mappings and compose/k8s configs keep working unchanged.
ENV ASPNETCORE_HTTP_PORTS=80
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Platform.csproj", "."]
RUN dotnet restore "./Platform.csproj"
# Install Node.js
RUN apt-get update && \
    apt-get install -y curl && \
    curl -sL https://deb.nodesource.com/setup_24.x | bash - && \
    apt-get install -y nodejs

COPY . .
WORKDIR "/src/."
RUN dotnet build "Platform.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Platform.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Platform.dll"]