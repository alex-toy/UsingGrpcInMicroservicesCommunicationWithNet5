# Using Grpc In Microservices Communication With .Net5

With **gRPC** in ASP.NET 5, we will develop high-performance, cross-platform applications for building distributed systems and APIs. It’s an ideal choice for communication between backend microservices, internal network applications, or iot devices and services. With the release of ASP.NET 5, Microsoft has added first-class support for creating gRPC services with Asp.Net 5.

In this project, we will build, develop and manage gRPC servers and clients on distributed microservices architecture.



## GrpcHelloWorld 

### Package Manager Command in **GrpcHelloWorldServer**
```
Install-Package Grpc.AspNetCore
```

### Package Manager Command in **GrpcHelloWorldClient**
```
Install-Package Grpc.Net.Client
Install-Package Google.Protobuf
Install-Package Grpc.Tools
```

<img src="/pictures/proto_config.png" title="proto config"  width="800">

### Package Manager Command in **GrpcGreeter**
```
Install-Package Grpc.AspNetCore
Install-Package Grpc.AspNetCore.Reflection
```

### Package Manager Command in **GrpcGreeterClient**
```
Install-Package Grpc.Net.Client
Install-Package Google.Protobuf
Install-Package Grpc.Tools
```

<img src="/pictures/proto_config2.png" title="proto config"  width="800">

### **grpc-curl**
```
grpcurl -d '{ \"name\": \"World\" }' localhost:5001 greet.Greeter/SayHello
grpcurl localhost:5001 describe
```

<img src="/pictures/grpc_reflexion.png" title="grpc reflexion"  width="800">




