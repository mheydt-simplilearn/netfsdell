"FROM mcr.microsoft.com/windows/servercore:ltsc2016 `n CMD echo Hello World!" | docker build -t mheydt/helloworld -
docker images
docker run mheydt/helloworld
docker login -u mheydt -p <> docker.io
docker image push mheydt/helloworld