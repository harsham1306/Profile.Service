FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS base
ENV ASPNETCORE_URLS http://*:5050
EXPOSE 5050
ADD Publish_Output /app
WORKDIR /app
ENTRYPOINT ["dotnet", "Profile.Service.dll"]