public class RepairsMenu : IMenu
{
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Select a device to get started");
        Console.WriteLine("[1] - Phone");
        Console.WriteLine("[2] - Tablet");
        Console.WriteLine("[3] - Computer");
        Console.WriteLine("[4] - Game Console");
        Console.WriteLine("[5] - return to previous menu");
    }    

    public string YourChoice()
    {
        string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                return "SearchRepairs";
            }
            else if (UserInput == "2")
            {
                return "AddRepairs";
            }
            else if (UserInput == "3")
            {
                return "ViewCart";  
            }
            else if (UserInput == "4")
            {
                return "MainMenu";
            }
            else 
            {
                Console.WriteLine("Please enter vaild response");
                return "MainMenu";
            }   
    }
}
