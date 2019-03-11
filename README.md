# Medit.MiniHost
基于.Net Fx-WCF实现的简单通信

项目结构的接单介绍：
1.Medit.Services
  定义服务的接口，也就是服务协议。服务端负责实现该项目中的接口，客户端调用该项目中定义的接口。
  
2.Medit.Implementations
  服务端针对Medit.Services的实现。

3.Medit.MiniHost
  服务端，使用ServiceHost实现远程服务。
  
 4.Medit.MiniClient
  客户端，继承ClientBase实现特定服务的调用。
