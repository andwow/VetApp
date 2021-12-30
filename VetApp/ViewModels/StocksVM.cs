using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using VetApp.Models;

namespace VetApp.ViewModels
{
    internal class StocksVM
    {
        public StocksVM()
        {
            Products = new ObservableCollection<Product>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Product]", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    Product prod = new Product();
                    prod.Id = (int)dt.Rows[i]["prod_id"];
                    prod.ProductCode = (string)dt.Rows[i]["prod_code"];
                    prod.Name = (string)dt.Rows[i]["prod_name"];
                    prod.Type = (int)dt.Rows[i]["type"];
                    prod.Price = (double)dt.Rows[i]["price"];
                    prod.Quantity = (double)dt.Rows[i]["quantity"];
                    Products.Add(prod);
                }
            }
            con.Close();
        }
        public ObservableCollection<Product> Products { get; }
    }
}
