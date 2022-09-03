FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["HolaWeb.App/HolaWeb.App.csproj", "HolaWeb.App/"]
RUN dotnet restore "HolaWeb.App/HolaWeb.App.csproj"
COPY . .
WORKDIR "/src/HolaWeb.App"
RUN dotnet build "HolaWeb.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HolaWeb.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HolaWeb.App.dll"]
