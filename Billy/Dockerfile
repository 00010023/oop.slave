FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Billy/Billy.csproj", "Billy/"]
RUN dotnet restore "Billy/Billy.csproj"
COPY . .
WORKDIR "/src/Billy"
RUN dotnet build "Billy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Billy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Billy.dll"]
