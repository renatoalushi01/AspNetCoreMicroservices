# AspNetCoreMicroservices

This project is build with Microservices on .Net platforms which used Asp.Net Web API, Docker, RabbitMQ, MassTransit, Grpc, Ocelot API Gateway, MongoDB, Redis, PostgreSQL, SqlServer, Dapper, Entity Framework Core, CQRS and Clean Architecture implementation

Installing Project:

Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)

1.Clone the repository

2.Once Docker for Windows is installed, go to the Settings > Advanced option, from the Docker icon in the system tray, to configure the minimum amount of memory and CPU like so:

Memory: 4 GB

CPU: 2

3. At the root directory which include docker-compose.yml files, run below command:

docker-compose -f docker-compose.yml -f docker-compose.override.yml up –d

4. Wait for docker compose all microservices. It takes some time to download all. That’s it! (some microservices need extra time to work so please wait if not worked in first shut)
