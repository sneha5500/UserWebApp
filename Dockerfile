# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app .

# ✅ Add --urls so it listens on port 80
ENTRYPOINT ["dotnet", "UserWebApp.dll", "--urls", "http://+:80"]
