using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;

HostAplicationBuilder = Host.CreateApplicationBuilder();
Builder.Services.AddSingleton<IUserActionWriter, DebugWriter>();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Buil();

AppLoger Logger = AppHost.Services.GetRequiredService<AppLoger>();
Logger.WriteLog("Application started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo" , "Azucar refinada");