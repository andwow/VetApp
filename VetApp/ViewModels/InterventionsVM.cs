using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;
using VetApp.Views;

namespace VetApp.ViewModels
{
    public class InterventionsVM
    {
        public InterventionsVM(int intvType, int petId)
        {
            PetId = petId;
            IntvType = intvType;
            InterventionList = new ObservableCollection<Intervention>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Intervention] where pet = @PetId and intv_type = @Type order by intv_date desc", con);
            cmd.Parameters.AddWithValue("@PetId", petId);
            cmd.Parameters.AddWithValue("@Type", intvType);
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
                    Intervention intv = new Intervention();
                    intv.Pet = (int)dt.Rows[i]["pet"];
                    intv.Vet = (int)dt.Rows[i]["vet"];
                    intv.Id = (int)dt.Rows[i]["intv_id"];
                    intv.Name = (string)dt.Rows[i]["intv_name"];
                    intv.Type = (int)dt.Rows[i]["intv_type"];
                    intv.Date = (DateTime)dt.Rows[i]["intv_date"];
                    if (dt.Rows[i]["intv_next_date"] != DBNull.Value)
                    {
                        intv.NextDate = (DateTime)dt.Rows[i]["intv_next_date"];
                    }
                    intv.Price = (double)dt.Rows[i]["price"];
                    InterventionList.Add(intv);
                }
            }
            con.Close();
        }
        public void Refresh()
        {
            InterventionList.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Intervention] where pet = @PetId and intv_type = @Type order by intv_date desc", con);
            cmd.Parameters.AddWithValue("@PetId", PetId);
            cmd.Parameters.AddWithValue("@Type", IntvType);
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
                    Intervention intv = new Intervention();
                    intv.Pet = (int)dt.Rows[i]["pet"];
                    intv.Vet = (int)dt.Rows[i]["vet"];
                    intv.Id = (int)dt.Rows[i]["intv_id"];
                    intv.Name = (string)dt.Rows[i]["intv_name"];
                    intv.Type = (int)dt.Rows[i]["intv_type"];
                    intv.Date = (DateTime)dt.Rows[i]["intv_date"];
                    if (dt.Rows[i]["intv_next_date"] != DBNull.Value)
                    {
                        intv.NextDate = (DateTime)dt.Rows[i]["intv_next_date"];
                    }
                    intv.Price = (double)dt.Rows[i]["price"];
                    InterventionList.Add(intv);
                }
            }
            con.Close();
        }

        public int PetId { get; }
        public int IntvType { get; }
        public ObservableCollection<Intervention> InterventionList { get; }
    }
}
