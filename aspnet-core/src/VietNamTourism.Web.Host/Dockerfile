FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/VietNamTourism.Web.Host/VietNamTourism.Web.Host.csproj", "src/VietNamTourism.Web.Host/"]
COPY ["src/VietNamTourism.Web.Core/VietNamTourism.Web.Core.csproj", "src/VietNamTourism.Web.Core/"]
COPY ["src/VietNamTourism.Application/VietNamTourism.Application.csproj", "src/VietNamTourism.Application/"]
COPY ["src/VietNamTourism.Core/VietNamTourism.Core.csproj", "src/VietNamTourism.Core/"]
COPY ["src/VietNamTourism.EntityFrameworkCore/VietNamTourism.EntityFrameworkCore.csproj", "src/VietNamTourism.EntityFrameworkCore/"]
WORKDIR "/src/src/VietNamTourism.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/VietNamTourism.Web.Host", "src/VietNamTourism.Web.Host"]
COPY ["src/VietNamTourism.Web.Core", "src/VietNamTourism.Web.Core"]
COPY ["src/VietNamTourism.Application", "src/VietNamTourism.Application"]
COPY ["src/VietNamTourism.Core", "src/VietNamTourism.Core"]
COPY ["src/VietNamTourism.EntityFrameworkCore", "src/VietNamTourism.EntityFrameworkCore"]
WORKDIR "/src/src/VietNamTourism.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "VietNamTourism.Web.Host.dll"]
