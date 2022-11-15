FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Ddp.Api/Ddp.Api.csproj", "Ddp.Api/"]
RUN dotnet restore "Ddp.Api/Ddp.Api.csproj"
COPY . .
WORKDIR "/src/Ddp.Api"
RUN dotnet build "Ddp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ddp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ddp.Api.dll"]
