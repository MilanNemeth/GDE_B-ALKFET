FROM mcr.microsoft.com/dotnet/sdk:10.0@sha256:0a506ab0c8aa077361af42f82569d364ab1b8741e967955d883e3f23683d473a AS build
WORKDIR /App
COPY DataAccess ./DataAccess/
COPY Domain ./Domain/
COPY WebApi ./WebApi/
COPY HeroBackend.slnx ./
# Override default port
# Restore as distinct layers
RUN dotnet restore HeroBackend.slnx
# Build and publish a release
RUN dotnet publish -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0@sha256:52dcfb4225fda614c38ba5997a4ec72cbd5260a624125174416e547ff9eb9b8c
WORKDIR /App
COPY --from=build /App/out .
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "WebApi.dll"]