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
                                values (@Name, @Location, @RepairType, @NumberofDevice, @DeviceType, @Total)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@Name", p_Order.Name);
                command.Parameters.AddWithValue("@Location", p_Order.Location);
                command.Parameters.AddWithValue("@RepairType", p_Order.RepairType);
                command.Parameters.AddWithValue("@NumberofDevice", p_Order.NumofDevice);
                command.Parameters.AddWithValue("@DeviceType", p_Order.DeviceType);
                command.Parameters.AddWithValue("@Total", p_Order.TotalPrice);

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
                        Name = reader.GetString(0),
                        Location = reader.GetString(1),
                        RepairType = reader.GetString(2),
                        NumofDevice = reader.GetInt32(3),
                        DeviceType = reader.GetString(4),
                        TotalPrice = reader.GetInt32(5)


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




