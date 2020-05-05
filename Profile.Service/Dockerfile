FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS base
ENV ASPNETCORE_URLS http://*:5050
EXPOSE 5050
COPY bin/Release/netcoreapp3.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "Profile.Service.dll"]