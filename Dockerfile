#Another stage that is all about running the application or how to run
from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app

# COPY --from=build /app/publish ./

#CMD docker instructions tells the docker engine how/where to run this application
cmd ["dotnet", "RepairShopv2Api.dll"]

#Expose to port 5000
expose 5000

env ASPNETCORE_URLS=https://+:5000