FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HtmxOutOfBandSample/HtmxOutOfBandSample.csproj", "HtmxOutOfBandSample/"]
RUN dotnet restore "HtmxOutOfBandSample/HtmxOutOfBandSample.csproj"
COPY . .
WORKDIR "/src/HtmxOutOfBandSample"
RUN dotnet build "HtmxOutOfBandSample.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HtmxOutOfBandSample.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HtmxOutOfBandSample.dll"]
