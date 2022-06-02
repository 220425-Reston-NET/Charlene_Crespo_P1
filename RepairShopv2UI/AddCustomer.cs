
using RepairShopv2BL;
using RepairShopv2Model;

public class AddCustomer : IMenu
{

    private Customers CustObj = new Customers();

    //=====Dependancy Injection Pattern=====
    private ICustomersBL _RepairShopv2BL;

    public AddCustomer(ICustomersBL p_RepairShopv2BL)
    {
        _RepairShopv2BL = p_RepairShopv2BL;
    }
    
    //======================================
    
    public void Display()
    {
        //Logic to Add Customer
        Console.Clear();
        Console.WriteLine("What is the name of the customer you would like to add");
        CustObj.Name = Console.ReadLine();
        Console.WriteLine("Please provide the address of the customer");
        CustObj.Address = Console.ReadLine();
        Console.WriteLine("Please provide the email of this customer?");
        CustObj.Email = Console.ReadLine();
        Console.WriteLine("What is the customers phone number?");
        //since number is an integer and console.readline gives a string, we have to convert to int
        
       try 
       {
            CustObj.Number = Convert.ToInt64(Console.ReadLine());
       }
       catch (System.Exception)
       {
            Log.Warning("User tried to add a negative number");
            Console.WriteLine("Number can only hold positive numbers");
       }
        Console.WriteLine("[1] - Add the Customer");
        Console.WriteLine("[0] - Exit");
    }

    public string YourChoice()
    {
        {
            string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                try
                {
                  _RepairShopv2BL.AddCustomer(CustObj);

                }
                catch (System.Exception)
                {
                    Log.Warning("Customer already Exist");
                    Console.WriteLine("Customer name already exist!");
                    Console.ReadLine();
                }

                return "MainMenu";
                // CustRepo.AddCustomers(CustObj);
            }
            else if (UserInput == "0")
            {
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please enter valid response");
                return "AddCustomer";
            }
        }
    }
}