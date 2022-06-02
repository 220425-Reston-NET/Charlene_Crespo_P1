// See https://aka.ms/new-console-template for more information

global using Serilog;
using Microsoft.Extensions.Configuration;
using RepairShopv2BL;
using RepairShopv2DL;
using RepairShopv2UI;

Console.Clear();

    //Initializing my logger
    Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt")
    .CreateLogger();

    var configuration = new ConfigurationBuilder() //Builder class used to create my configuration object
        .SetBasePath(Directory.GetCurrentDirectory()) //Sets the base path to the current directory
        .AddJsonFile("appsettings.json") //Grabs the specific json file on where the information is from
        .Build(); //Creates the object

IMenu menu = new MainMenu();
bool repeat = true;

while (repeat)
{
    menu.Display();
    string ans = menu.YourChoice();

    if (ans == "MainMenu")
    {
        Log.Information("User going to MainMaenu");
        menu = new MainMenu();
    }
    else if (ans == "CustomerMenu")
    {
        Log.Information("User going to Customer Menu");
        menu = new CustomerMenu();
    }
    else if (ans == "AddCustomers")
    {
        Log.Information("User added new customer");
        menu = new AddCustomer(new CustomersBL(new SQLCustomerRepository(configuration.GetConnectionString("Charlene Crespo"))));
    }
    else if (ans == "SearchCustomer")
    {
        Log.Information("User searched a customer");
        menu = new SearchCustomer(new CustomersBL(new SQLCustomerRepository(configuration.GetConnectionString("Charlene Crespo"))));
    }
    else if (ans == "RepairsMenu")
    {
        menu = new RepairsMenu();
    }
    else if (ans == "Exit")
    {
        Log.Information("User exit application");
        repeat = false;
    }
}

    

