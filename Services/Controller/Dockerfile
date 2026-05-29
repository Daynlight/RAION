# ETAP 1: Budowanie
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false



FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

RUN addgroup --system --gid 1001 appgroup && \
    adduser --system --uid 1001 --ingroup appgroup appuser
USER appuser

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "Controller.Api.dll"]