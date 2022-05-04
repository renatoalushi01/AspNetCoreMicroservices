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



All tech & tools Included 

- ASPNET Core Web API Development of Microservices
- REST API Principles, CRUD Operations
- Mongo DB and Redis NoSQL Database Connection on Docker
- Entity Framework Core with SQL Server Database Connection on Docker
- N-Layer implementation with Repository Pattern
- Swagger Open API implementation
- Consume Discount Grpc Service for inter-service sync communication to calculate product final price
- Publish BasketCheckout Queue with using MassTransit and RabbitMQ
- Build a Highly Performant inter-service gRPC Communication with Basket Microservice
- Using Dapper for micro-orm implementation to simplify data access and ensure high performance
- PostgreSQL database connection and containerization
- Async Microservices Communication with RabbitMQ Message-Broker Service
- Using RabbitMQ Publish/Subscribe Topic Exchange Model
- Using MassTransit for abstraction over RabbitMQ Message-Broker system
- Implementing DDD, CQRS, and Clean Architecture with using Best Practices
- Developing CQRS with using MediatR, FluentValidation and AutoMapper packages
- Consuming RabbitMQ BasketCheckout event queue with using MassTransit-RabbitMQ Configuration
- Using Entity Framework Core ORM and auto migrate to SqlServer when application startup
- Ocelot API Gateway Development of Microservices
- Call Ocelot APIs with HttpClientFactory
- The Gateway aggregation pattern in Shopping Aggregator
- ASPNET Core Web Application with Bootstrap 4 and Razor template
- Docker Compose Containerization of All Microservices
- Use Portainer for Container lightweight management UI which allows you to easily manage your different Docker environments
  pgAdmin PostgreSQL Tools feature rich Open Source administration and development platform for PostgreSQL
