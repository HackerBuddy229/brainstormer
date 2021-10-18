FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Brainstormer/Brainstormer.csproj", "Brainstormer/"]
RUN dotnet restore "Brainstormer/Brainstormer.csproj"
COPY . .
WORKDIR "/src/Brainstormer"
RUN dotnet build "Brainstormer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Brainstormer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Brainstormer.dll"]
