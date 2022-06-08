#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

EXPOSE 5050
ENV ASPNETCORE_URLS=http://+:5050

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["eBordo.Api/eBordo.Api.csproj", "eBordo.Api/"]
RUN dotnet restore "eBordo.Api/eBordo.Api.csproj"
COPY . .
WORKDIR "/src/eBordo.Api"
RUN dotnet build "eBordo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eBordo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eBordo.Api.dll"]