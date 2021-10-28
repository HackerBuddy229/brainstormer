FROM mcr.microsoft.com/dotnet/aspnet:6.0.0-rc.2 AS base
WORKDIR /app

EXPOSE 80/tcp
EXPOSE 443/tcp

FROM mcr.microsoft.com/dotnet/sdk:6.0.100-rc.2 AS build
WORKDIR /src
COPY . .
RUN dotnet restore Brainstormer/
RUN dotnet build "Brainstormer/Brainstormer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Brainstormer/Brainstormer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Brainstormer.dll"]
