ARG Host
ARG Port
ARG Database
ARG Username
ARG Password

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

ARG Host


# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore 
    
# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
    
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 5001
ENTRYPOINT ["dotnet", "PersonManagementService.API.dll", "/Database:Host=$Host"]