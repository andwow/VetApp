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
    class ClientProfileVM
    {
        public ClientProfileVM(User user)
        {
            CurrentUser = user;
            Pets = new ObservableCollection<Pet>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [Pet] where owner = @Owner", con);
            cmd.Parameters.AddWithValue("@Owner", user.Id);
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
                    Pet pet = new Pet()
                    {
                        Id = (int)dt.Rows[i]["pet_id"],
                        PersonalCode = (string)dt.Rows[i]["personal_code"],
                        Name = (string)dt.Rows[i]["name"],
                        Birthday = (DateTime)dt.Rows[i]["birthday"],
                        Gender = (string)dt.Rows[i]["gender"],
                        Species = (string)dt.Rows[i]["species"],
                        Breed = (string)dt.Rows[i]["breed"],
                        Color = (string)dt.Rows[i]["color"],
                        Marks = (string)dt.Rows[i]["marks"]
                    };
                    Pets.Add(pet);
                }

            }
            con.Close();
        }

        public ObservableCollection<Pet> Pets { get; }
        public User CurrentUser { get; }
    }
}
