# Using Grpc In Microservices Communication With .Net5

With **gRPC** in ASP.NET 5, we will develop high-performance, cross-platform applications for building distributed systems and APIs. It’s an ideal choice for communication between backend microservices, internal network applications, or iot devices and services. With the release of ASP.NET 5, Microsoft has added first-class support for creating gRPC services with Asp.Net 5.

In this project, we will build, develop and manage gRPC servers and clients on distributed microservices architecture.




## GrpcHelloWorld 

### Package Manager Command in **GrpcHelloWorldServer**
```
Install-Package Grpc.AspNetCore ##2.33.1 version
```

### Package Manager Command in **GrpcHelloWorldClient**
```
Install-Package Grpc.Net.Client ##2.33.1 version
Install-Package Google.Protobuf ##3.14.1 version
Install-Package Grpc.Tools ##2.33.1 version
```

### Deployment

1. Run *Articles.API* microservice **locally**
- Run :
```
docker start articles-mongo
```
- In *appsettings.Development.json*, set : "ConnectionString" : "mongodb://localhost:27017"
- Hit **Articles.API**

<img src="/pictures/article_swagger.png" title="article swagger"  width="800">

2. Run *Articles.API* microservice **containerized**
- In *appsettings.Development.json*, set : "ConnectionString" : "mongodb://articlemongodb:27017"
- Hit **Docker Compose**

3. Run *Articles.API* microservice **docker compose**
```
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
```
- go to *Articles.API* : http://localhost:8000/swagger/index.html

<img src="/pictures/article_swagger_docker.png" title="article swagger_docker"  width="800">





Install-Package Npgsql 
Install-Package Dapper 
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection 
Update-Package -ProjectName Vehicles.Grpc

Install-Package AutoMapper
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
Install-Package Swashbuckle.AspNetCore.SwaggerUI 
Install-Package Swashbuckle.AspNetCore.Annotations 
Install-Package Microsoft.AspNetCore.Authentication.Jwtbearer
Install-Package Microsoft.EntityFrameworkCore.SqlServer 
Install-Package Microsoft.EntityFrameworkCore.Tools 