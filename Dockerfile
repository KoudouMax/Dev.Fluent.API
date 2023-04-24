FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Dev.Fluent.API/Dev.Fluent.API.csproj", "/Dev.Fluent.API"]
COPY ["Dev.Fluent.API.Application/Dev.Fluent.Applications.csproj", "Dev.Fluent.Application"]
COPY ["Dev.Fluent.Common/Dev.Fluent.Common.csproj", "Dev.Fluent.Common"]
COPY ["Dev.Fluent.Data/Dev.Fluent.Data.csproj", "Dev.Fluent.Data"]
COPY ["Dev.Fluent.Domains/Dev.Fluent.Domains.csproj", "Dev.Fluent.Domain"]
COPY ["Dev.Fluent.IoC/Dev.Fluent.IoC.csproj", "Dev.Fluent.IoC"]
RUN dotnet restore "Dev.Fluent.API/Dev.Fluent.API.csproj"
COPY . .
RUN dotnet build "Dev.Fluent.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Dev.Fluent.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Dev.Fluent.API.dll"]