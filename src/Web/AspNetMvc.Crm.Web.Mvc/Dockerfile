#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Web/AspNetMvc.Crm.Web.Mvc/AspNetMvc.Crm.Web.Mvc.csproj", "src/Web/AspNetMvc.Crm.Web.Mvc/"]
RUN dotnet restore "src/Web/AspNetMvc.Crm.Web.Mvc/AspNetMvc.Crm.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/Web/AspNetMvc.Crm.Web.Mvc"
RUN dotnet build "AspNetMvc.Crm.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspNetMvc.Crm.Web.Mvc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspNetMvc.Crm.Web.Mvc.dll"]