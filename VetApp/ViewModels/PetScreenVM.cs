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
    public class PetScreenVM
    {
        public PetScreenVM(Pet pet)
        {
            this.CurrentPet = new Pet(pet);
            Interventions = new ObservableCollection<Intervention>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Intervention] where pet = @PetId", con);
            cmd.Parameters.AddWithValue("@PetId", pet.Id);
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
                    Interventions.Add(intv);
                }
            }
            con.Close();
        }

        public ObservableCollection<Intervention> Interventions { get; }
        public Pet CurrentPet { get; }
    }
}
