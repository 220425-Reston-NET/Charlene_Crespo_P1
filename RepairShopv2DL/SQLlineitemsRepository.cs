using Microsoft.Data.SqlClient;
using RepairShopv2Model;

namespace RepairShopv2DL
{

    public class SQLlineitemsRepository : IRepository<LineItems>
    {

        private string _connectionString;
            
            public SQLlineitemsRepository(string p_connectionString)
            {
                this._connectionString = p_connectionString;
            }
        public void Add(LineItems p_line)
        {
            string SQLQuery = @"insert into LineItems
                                values (@OrderID, @ProdID, @Description, @QTY, @AMT)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@OrderID", p_line.OrderID);
                command.Parameters.AddWithValue("@ProdID", p_line.ProdID);
                command.Parameters.AddWithValue("@QTY", p_line.QTY);
                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }
        public List<LineItems> GetAll()
        {
           string SQLQuery = @"select * from LineItems";
           List<LineItems> listoflineitems = new List<LineItems>();

           using (SqlConnection con = new SqlConnection(_connectionString))
           {
               con.Open();

               SqlCommand command = new SqlCommand(SQLQuery, con);

               SqlDataReader reader = command.ExecuteReader();

               while (reader.Read())
               {
                   listoflineitems.Add(new LineItems(){
                       OrderID = reader.GetInt32(0),
                       ProdID = reader.GetInt32(1),
                       QTY = reader.GetInt32(3),

                   });
               }

               return listoflineitems;
            }
        }
        public void Update(LineItems p_resource)
        {
            throw new NotImplementedException();
        }
    }
}




