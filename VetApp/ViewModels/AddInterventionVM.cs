using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.ViewModels
{
    public class AddInterventionVM
    {
        public AddInterventionVM(int intvType)
        {
            if(intvType == 1 || intvType == 2)
            {
                Visible = true;
            }
            CurrentIntervention = new Intervention();
            CurrentIntervention.Date = DateTime.Today;
            CurrentIntervention.NextDate = DateTime.Today.AddDays(30);
            AvailableProducts = new ObservableCollection<Product>();
            UsedProducts = new ObservableCollection<Product>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Product] where type = @IntvType", con);
            cmd.Parameters.AddWithValue("@IntvType", intvType);
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
                    AvailableProducts.Add(prod);
                }
            }
            con.Close();
        }
        public bool Visible { get; }
        public Intervention CurrentIntervention { get; }
        public string PriceString
        {
            get
            {
                return CurrentIntervention.Price.ToString();
            }
            set
            {
                CurrentIntervention.Price = double.Parse(value);
            }
        }
        public ObservableCollection<Product> AvailableProducts { get; }
        public ObservableCollection<Product> UsedProducts { get; }
    }
}
