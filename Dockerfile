#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["rs2_amina_delihodic/EProdajaRacunarskeOpreme.WebApi.csproj", "rs2_amina_delihodic/"]
COPY ["Prodaja.Model/Prodaja.Model.csproj", "Prodaja.Model/"]
RUN dotnet restore "rs2_amina_delihodic/EProdajaRacunarskeOpreme.WebApi.csproj"
COPY . .
WORKDIR "/src/rs2_amina_delihodic"
RUN dotnet build "EProdajaRacunarskeOpreme.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EProdajaRacunarskeOpreme.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EProdajaRacunarskeOpreme.WebApi.dll"]