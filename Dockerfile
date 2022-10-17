FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /app

COPY *.sln .
COPY ["Devops.Tp1.Test/*.csproj" , "Devops.Tp1.Test/"]
COPY ["Devops.Tp1.WebApi/*.csproj", "Devops.Tp1.WebApi/"]
COPY ["Devops.Tp1.Service/*.csproj" , "Devops.Tp1.Service/"]
COPY ["Devops.Tp1.Logic/*.csproj","Devops.Tp1.Logic/"]
COPY ["Devops.Tp1.Domain/*.csproj" , "Devops.Tp1.Domain/"]
COPY ["Devops.Tp1.ResourceAcces/*.csproj" , "Devops.Tp1.ResourceAcces/"]


RUN dotnet restore 

COPY ["Devops.Tp1.Test/." , "./Devops.Tp1.Test/"]
COPY ["Devops.Tp1.WebApi/.", "./Devops.Tp1.WebApi/"]
COPY ["Devops.Tp1.Service/.","./Devops.Tp1.Service/"]
COPY ["Devops.Tp1.Logic/." , "./Devops.Tp1.Logic"]
COPY ["Devops.Tp1.ResourceAcces/." , "./Devops.Tp1.ResourceAcces/"]
COPY ["Devops.Tp1.Domain/." , "./Devops.Tp1.Domain/"]


WORKDIR /app/Devops.Tp1.WebApi
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS runtime
WORKDIR /app
COPY --from=build /app/Devops.Tp1.WebApi/out ./
EXPOSE 80

ENTRYPOINT ["dotnet", "Devops.Tp1.WebApi.dll"]