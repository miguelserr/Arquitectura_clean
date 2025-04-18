using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;

IUserActionWriter Writer = new FileWriter();

AppLoger Logger = new AppLoger(Writer);
Logger.WriteLog("Application started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo" , "Azucar refinada");