FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["HolaWeb.App.Frontend/HolaWeb.App.Frontend.csproj", "HolaWeb.App.Frontend/"]
RUN dotnet restore "HolaWeb.App.Frontend/HolaWeb.App.Frontend.csproj"
COPY . .
WORKDIR "/src/HolaWeb.App.Frontend"
RUN dotnet build "HolaWeb.App.Frontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HolaWeb.App.Frontend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HolaWeb.App.Frontend.dll"]
