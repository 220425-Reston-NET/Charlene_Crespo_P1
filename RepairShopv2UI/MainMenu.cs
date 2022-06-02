namespace RepairShopv2UI
{
    public class MainMenu : IMenu
    {
       public void Display()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my RepairShop! What can i do for you today?");
            Console.WriteLine("[1] - Repairs");
            Console.WriteLine("[2] - Store Locations");
            Console.WriteLine("[3] - New or Existing Customers");
            Console.WriteLine("[4] - Exit");
        }

        public string YourChoice()
        {
            
           string UserInput = Console.ReadLine();
            if (UserInput == "1")
            {
                return "RepairsMenu";
            }
            else if (UserInput == "2")
            {
                return "Locations";
            }
            else if (UserInput == "3")
            {
                return "CustomerMenu";
            }
            else if (UserInput == "4")
            {
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please input valid response");
                return "MainMenu";
            }
            
        }
    }                        
}                 
            

        


    





