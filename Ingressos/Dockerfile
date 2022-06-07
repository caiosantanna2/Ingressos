#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:8000;http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ingressos/Ingressos.API.csproj", "Ingressos/"]
RUN dotnet restore "Ingressos/Ingressos.API.csproj"
COPY . .
WORKDIR "/src/Ingressos"
RUN dotnet build "Ingressos.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ingressos.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ingressos.API.dll"]