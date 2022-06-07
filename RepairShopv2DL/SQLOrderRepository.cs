using Microsoft.Data.SqlClient;
using RepairShopv2Model;

namespace RepairShopv2DL
{

    public class SQLOrderRepository : IRepository<Order>
    {

        private string _connectionString;
            
            public SQLOrderRepository(string p_connectionString)
            {
                this._connectionString = p_connectionString;
            }
        public void Add(Order p_Order)
        {
            string SQLQuery = @"insert into Orders
                                values (@OrderID, @CustID, @StoreID, @TotalPrice)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@OrderID", p_Order.OrderID);
                command.Parameters.AddWithValue("@CustID", p_Order.CustID);
                command.Parameters.AddWithValue("@StoreID", p_Order.StoreID);
                command.Parameters.AddWithValue("@TotalPrice", p_Order.TotalPrice);

                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }
        public List<Order> GetAll()
        {
            string SQLQuery = @"select * from Orders";
            List<Order> listofOrder = new List<Order>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofOrder.Add(new Order(){
                        OrderID = reader.GetInt32(0),
                        CustID = reader.GetInt32(1),
                        StoreID = reader.GetInt32(2),
                        TotalPrice = reader.GetDecimal(3)


                    });
                }

                return listofOrder;
            }
        }
           public void Update(Order p_Order)
        {
        
        }
    }
}




