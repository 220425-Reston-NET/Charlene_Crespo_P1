     public class CustomerMenu : IMenu
    {
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] - Add new Customer");
            Console.WriteLine("[2] - Search Customer");
            Console.WriteLine("[3] - return to previous menu");
        }

        public string YourChoice()
        {
            string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                return "AddCustomers";
            }
            else if (UserInput == "2")
            {
                return "SearchCustomer";
            }
            else if (UserInput == "3")
            {
                return "MainMenu";  
            }
            else 
            {
                Console.WriteLine("Please enter vaild response");
                return "CustomerMenu";
            }
        }
    }

