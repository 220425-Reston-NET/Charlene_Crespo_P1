using Microsoft.Data.SqlClient;
using RepairShopv2Model;

namespace RepairShopv2DL
{
    public class SQLCustomerRepository : IRepository<Customers>
    {
        private string _connectionString;
        
        public SQLCustomerRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;

        }
        public void Add(Customers p_cust)
        {
             string SQLQuery = @"insert into Customers 
                                values (@Name, @Number, @Address, @Email)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@Name", p_cust.Name);
                command.Parameters.AddWithValue("@Number", p_cust.Number);
                command.Parameters.AddWithValue("@Address", p_cust.Address);
                command.Parameters.AddWithValue("@Email", p_cust.Email);

                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }
        public List<Customers> GetAll()
        {
           string SQLQuery = @"select * from Customers";
           List<Customers> listofCustomers = new List<Customers>();

           using (SqlConnection con = new SqlConnection(_connectionString))
           {
               con.Open();

               SqlCommand command = new SqlCommand(SQLQuery, con);

               SqlDataReader reader = command.ExecuteReader();

               while (reader.Read())
               {
                   listofCustomers.Add(new Customers(){
                       Name = reader.GetString(0),
                       Number = reader.GetInt64(1),
                       Address = reader.GetString(2),
                       Email = reader.GetString(3)

                   });
               }

               return listofCustomers;
           }



        }

        public void Update(Customers p_resource)
        {
            throw new NotImplementedException();
        }
    }
}