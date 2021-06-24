[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
Invoke-WebRequest "https://github.com/docker/compose/releases/download/1.25.3/docker-compose-Windows-x86_64.exe" -UseBasicParsing -OutFile $Env:ProgramFiles\Docker\docker-compose.exe
docker-compose –version
git clone https://github.com/dotnet-architecture/eShopOnContainers.git
# copy in docker compose

docker-custom.yml up --build