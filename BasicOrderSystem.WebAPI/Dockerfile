FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5275

ENV ASPNETCORE_URLS=http://+:5275

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["BasicOrderSystem.WebAPI/BasicOrderSystem.WebAPI.csproj", "BasicOrderSystem.WebAPI/"]
COPY ["BasicOrderSystem.Models/BasicOrderSystem.Models.csproj", "BasicOrderSystem.Models/"]
COPY ["BasicOrderSystem.WebContracts/BasicOrderSystem.WebContracts.csproj", "BasicOrderSystem.WebContracts/"]
RUN dotnet restore "BasicOrderSystem.WebAPI/BasicOrderSystem.WebAPI.csproj"
COPY . .
WORKDIR "/src/BasicOrderSystem.WebAPI"
RUN dotnet build "BasicOrderSystem.WebAPI.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "BasicOrderSystem.WebAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BasicOrderSystem.WebAPI.dll"]
