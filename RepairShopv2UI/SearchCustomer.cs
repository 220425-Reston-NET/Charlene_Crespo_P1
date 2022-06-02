using RepairShopv2BL;
using RepairShopv2Model;

public class SearchCustomer : IMenu
{
    private Customers CustObj = new Customers();
    public static Customers foundedCustomer;

    //===========Dependency Injection===========
    private ICustomersBL _CustBL;
    public SearchCustomer(ICustomersBL p_CustBL)
    {
        _CustBL = p_CustBL;
    }

    //==========================================
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("How would you like to search for Customer?");
        Console.WriteLine("[1] - Search by Name");
        Console.WriteLine("[2] - Search by Number");
        Console.WriteLine("[3] - Search by Receipts");
        Console.WriteLine("[4] - Return to previous menu");
        Console.WriteLine("[5] - Exit");
    }

    public string YourChoice()
    {
         string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            //Search logic by Name
            Console.WriteLine("Enter Customer Name: ");
            string CustName = Console.ReadLine();

            foundedCustomer = _CustBL.SearchCustomerByName(CustName);
 
            //condition to display customer info if customer is found
            if (foundedCustomer == null) 
            {
                Console.WriteLine("Customer was not found!");
            }
            else
            {
                Console.WriteLine(foundedCustomer.ToString());

                //Ask user if they want to add an order to existing customer
                Console.WriteLine("Would you like to add a new repair to this customer? (Y - Yes, N -No)");
                string addCustChoice = Console.ReadLine();
                if (addCustChoice == "Y")
                {
                    return "AddRepair";
                }
                else
                {
                    return "SearchCustomer";
                }
            }
        }
        else if (userInput == "2")
        {
            //Search logic by Number
            Console.WriteLine("Enter Customer Number: ");
            try 
       {
            CustObj.Number = Convert.ToInt64(Console.ReadLine());
       }
            catch (System.Exception)
       {
            Console.WriteLine("Number can only hold positive numbers");
       }
            
            foundedCustomer = _CustBL.SearchCustomerByNumber(CustObj.Number);

            //Condition that it should only display the pokemon info if it found a pokemon
            if (foundedCustomer == null)
            {
                Console.WriteLine("Customer was not found!");
            }
            else
            {
                Console.WriteLine(foundedCustomer.ToString());

                //Ask user if they want to add a new repair to customer
                Console.WriteLine("Do you want to add a Repair to this Customer? (Y - Yes, N - No)");
                string addCustChoice = Console.ReadLine();
                if (addCustChoice == "Y")
                {
                    return "AddRepair";
                }
                else
                {
                    return "SearchCustomer";
                }
            }
        }
        else if (userInput == "3")
        {
            //Search logic by Repairs
           Console.WriteLine("Enter Repair Type: ");
            string CustRepairs = Console.ReadLine();
            
            foundedCustomer = _CustBL.SearchCustomerByRepairs(CustRepairs);

            //Condition that it should only display the customer info if it was found
            if (foundedCustomer == null)
            {
                Console.WriteLine("Customer was not found!");
            }
            else
            {
                Console.WriteLine(foundedCustomer.ToString());

                //Ask user if they want to add an order to this customer
                Console.WriteLine("Do you want to add a repair to this Customer? (Y - Yes, N - No)");
                string addCustChoice = Console.ReadLine();
                if (addCustChoice == "Y")
                {
                    return "AddRepair";
                }
                else
                {
                    return "SearchCustomer";
                }
            } 
        }
        else if (userInput == "4")
        {
            //Exit
            return "CustomerMenu";
        }
        else if (userInput == "5")
        {
            //Exit
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "SearchCustomer";
        }
        return "MainMenu";
    }
}
