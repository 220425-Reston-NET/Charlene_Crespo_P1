using Microsoft.Data.SqlClient;
using RepairShopv2Model;

namespace RepairShopv2DL
{

    public class SQLLocationRepository : IRepository<Locations>
    {
        //===================Dependency Injection =========================
        private string _connectionString;
        
        public SQLLocationRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;

        }

        //==================================================================

        public void Add(Locations p_resource)
        {
            throw new NotImplementedException();
        }

        public List<Locations> GetAll()
        {
            string sqlQuery = @"select * from Locations";
            List<Locations> listOfLocations = new List<Locations>();


            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfLocations.Add(new Locations(){
                        StoreID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Products = GetProductsFromLocation(reader.GetInt32(0))

                    });

                }

            }
            return listOfLocations;
        }
        
            private List<Products> GetProductsFromLocation(int p_StoreID)
            {
                string sqlQuery = @"select l.Name, p.ProdID, p.Description,  i.QTY from Locations l
                                    inner join Inventory i on l.StoreID = i.StoreID
                                    inner join Products p on i.ProdID = p.ProdID 
                                    where l.StoreID = @StoreID";
                
                List<Products> listOfProducts = new List<Products>();

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand(sqlQuery, con);

                    command.Parameters.AddWithValue("@StoreID", p_StoreID);

                    SqlDataReader reader = command.ExecuteReader();

                     while (reader.Read())
                    {
                            listOfProducts.Add(new Products(){
                            ProdID = reader.GetInt32(1),
                            Description = reader.GetString(3),
                            QTY = reader.GetInt32(4)
                        });
                    }
                }
                return listOfProducts;

            }
                public void Update(Locations p_resource)
                {
                    throw new NotImplementedException();
                }
    }
}