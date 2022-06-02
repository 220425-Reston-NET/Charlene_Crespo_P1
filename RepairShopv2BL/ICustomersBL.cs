using RepairShopv2Model;

namespace RepairShopv2BL
{
    public interface ICustomersBL
    {
        /// <summary>
        /// Add customer to the database
        /// </summary>
        /// <param name="p_cust">This is the customer object that will be added to the database</param>
        /// <returns>Gives back the customer that gets added to the DB</returns>
        void AddCustomer(Customers p_cust);

        List<Customers> GetAllCustomers();


        // /// <summary>
        // /// This will search Customer in the DB by Name
        // /// </summary>
        // /// <param name="p_Name">Name of Customer used to search </param>
        // /// <returns>Multiple customers if they have matching names </returns>
        // List<Customers> 

        Customers SearchCustomerByName(string p_Name);

        Customers SearchCustomerByNumber(long p_Number);

        void AddRepairsToCustomers(Customers p_Customers);
        Customers SearchCustomerByRepairs(string custRepairs);
    }
}