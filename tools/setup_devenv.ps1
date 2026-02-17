#!/usr/bin/env pwsh
$networExists = docker network ls --filter name=balkfet-network --format "{{.Name}}" | grep -w balkfet-network
if ($null -eq $networExists) {
    docker network create balkfet-network
}

$dbContainerExists = docker ps -a --filter name=balkfet-mongodb --format "{{.Names}}" | grep -w balkfet-mongodb
if ($null -eq $dbContainerExists) {
    docker run -d --name balkfet-mongodb --network balkfet-network -p 127.0.0.1:27017:27017 --mount "type=volume,src=balkfet-mongodb,dst=/data" mongo:8
}
else {
    docker start balkfet-mongodb
}

exit 0