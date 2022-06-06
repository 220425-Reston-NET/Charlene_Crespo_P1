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
                command.Parameters.AddWithValue("@Description", p_line.Description);
                command.Parameters.AddWithValue("@QTY", p_line.QTY);
                command.Parameters.AddWithValue("@AMT", p_line.AMT);
                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }
        public void Update(LineItems p_resource)
        {
            throw new NotImplementedException();
        }

        List<LineItems> IRepository<LineItems>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}




