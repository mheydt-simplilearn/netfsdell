git clone https://github.com/dotnet/dotnet-docker
cd dotnet-docker/samples/aspnetapp/aspnetapp
dotnet run
open http://localhost:5000
cd dotnet-docker/samples/aspnetapp
docker run --name aspnet_sample --rm -it -p 8000:80 mcr.microsoft.com/dotnet/framework/samples:aspnetapp
docker exec aspnet_sample ipconfig
