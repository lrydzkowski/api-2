#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api2.WebApi/Api2.WebApi.csproj", "Api2.WebApi/"]
RUN dotnet restore "Api2.WebApi/Api2.WebApi.csproj"
COPY . .
WORKDIR "/src/Api2.WebApi"
RUN dotnet build "Api2.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api2.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api2.WebApi.dll"]