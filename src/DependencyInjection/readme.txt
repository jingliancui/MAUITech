https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/ioc
1.根据上放链接教程，viewmodel用构造注入，
只需要注意在注册服务时，viewmodel也作为服务注册即可，那构造viewmodel时需要的服务也会被注入到viewmodel。

https://learn.microsoft.com/en-us/dotnet/architecture/maui/dependency-injection#resolution
2.在view设置viewmodel时，只需要使用Handler.MauiContext.Services.GetServices来获取viewmodel即可。