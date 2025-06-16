FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/VietNamTourism.Web.Mvc/VietNamTourism.Web.Mvc.csproj", "src/VietNamTourism.Web.Mvc/"]
COPY ["src/VietNamTourism.Web.Core/VietNamTourism.Web.Core.csproj", "src/VietNamTourism.Web.Core/"]
COPY ["src/VietNamTourism.Application/VietNamTourism.Application.csproj", "src/VietNamTourism.Application/"]
COPY ["src/VietNamTourism.Core/VietNamTourism.Core.csproj", "src/VietNamTourism.Core/"]
COPY ["src/VietNamTourism.EntityFrameworkCore/VietNamTourism.EntityFrameworkCore.csproj", "src/VietNamTourism.EntityFrameworkCore/"]
WORKDIR "/src/src/VietNamTourism.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/VietNamTourism.Web.Mvc", "src/VietNamTourism.Web.Mvc"]
COPY ["src/VietNamTourism.Web.Core", "src/VietNamTourism.Web.Core"]
COPY ["src/VietNamTourism.Application", "src/VietNamTourism.Application"]
COPY ["src/VietNamTourism.Core", "src/VietNamTourism.Core"]
COPY ["src/VietNamTourism.EntityFrameworkCore", "src/VietNamTourism.EntityFrameworkCore"]
WORKDIR "/src/src/VietNamTourism.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "VietNamTourism.Web.Mvc.dll"]
