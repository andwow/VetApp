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
    public class InterventionDetailsVM
    {
        public InterventionDetailsVM(Intervention intervention)
        {
            CurrentIntervention = intervention;
            if(intervention.Type == 1 || intervention.Type == 2)
            {
                Visible = true;
            }
            InterventionItems = new ObservableCollection<Items>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Items] where intervention_id = @Intv", con);
            cmd.Parameters.AddWithValue("@Intv", intervention.Id);
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
                    Items item = new Items
                    {
                        ProductId = (int)dt.Rows[i]["product_id"],
                        InterventionId = (int)dt.Rows[i]["intervention_id"],
                        Id = (int)dt.Rows[i]["items_id"],
                        Name = (string)dt.Rows[i]["prod_name"],
                        Type = (int)dt.Rows[i]["items_type"],
                        Quantity = (double)dt.Rows[i]["items_quantity"],
                        Price = (double)dt.Rows[i]["items_price"]
                    };
                    InterventionItems.Add(item);
                    TotalPrice += item.Price * item.Quantity;
                }
            }
            con.Close();
        }
        public bool Visible { get; }
        public Intervention CurrentIntervention { get; }
        public ObservableCollection<Items> InterventionItems { get; }
        public double TotalPrice { get; }
        public string TotalPriceStr
        {
            get
            {
                return TotalPrice.ToString();
            }
        }
    }
}
