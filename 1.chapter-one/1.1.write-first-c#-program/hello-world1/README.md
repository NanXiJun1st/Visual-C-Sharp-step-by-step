## note  
---
为确保本书中程序正常运行，请在Visual Studio 安装 
- ASP.Net 和 Web 开发
- Azure开发
- .Net桌面开发
- 通用Windows平台开发
- 数据储存和处理
- ~~.Net Core跨平台开发~~（Visual Studio Community 2022 17.7.3中未找到该选项）  

## 问题记录
---
**dotnet运行错误01**  
```
$ dotnet run  
Could not execute because the application was not found or a compatible .NET SDK is not installed.
Possible reasons for this include:
  * You intended to execute a .NET program:
      The application 'run' does not exist.
  * You intended to execute a .NET SDK command:
      It was not possible to find any installed .NET SDKs.
      Install a .NET SDK from:
        https://aka.ms/dotnet-download
```
**解决方案**  
```
确保已正确安装.Net SDK
```
**dotnet运行错误02**  
```
The command could not be loaded, possibly because:
  * You intended to execute a .NET application:
      The application 'run' does not exist.
  * You intended to execute a .NET SDK command:
      No .NET SDKs were found.

Download a .NET SDK:
https://aka.ms/dotnet/download

Learn about SDK resolution:
https://aka.ms/dotnet/sdk-not-found
```
**解决方案**  
该错误可能是由vscode插件造成的  
```
删除C:\Program Files (x86)\dotnet文件夹
```  