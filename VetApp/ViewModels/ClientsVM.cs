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
    class ClientsVM
    {
        public ClientsVM()
        {
            Clients = new ObservableCollection<User>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [User] where is_vet = 0", con);
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
                    User user = new User();
                    user.Id = (int)dt.Rows[i]["user_id"];
                    user.Cnp = (string)dt.Rows[i]["cnp"];
                    user.FirstName = (string)dt.Rows[i]["first_name"];
                    user.LastName = (string)dt.Rows[i]["last_name"];
                    user.Email = (string)dt.Rows[i]["email"];
                    user.Password = (string)dt.Rows[i]["password"];
                    user.IsVet = (bool)dt.Rows[i]["is_vet"];
                    user.Phone = (string)dt.Rows[i]["phone_no"];
                    user.Country = (string)dt.Rows[i]["country"];
                    user.District = (string)dt.Rows[i]["district"];
                    user.City = (string)dt.Rows[i]["city"];
                    user.Address = (string)dt.Rows[i]["address"];
                    Clients.Add(user);
                }

            }
            con.Close();
        }

        public void Refresh()
        {
            Clients.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [User] where is_vet = 0", con);
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
                    User user = new User();
                    user.Id = (int)dt.Rows[i]["user_id"];
                    user.Cnp = (string)dt.Rows[i]["cnp"];
                    user.FirstName = (string)dt.Rows[i]["first_name"];
                    user.LastName = (string)dt.Rows[i]["last_name"];
                    user.Email = (string)dt.Rows[i]["email"];
                    user.Password = (string)dt.Rows[i]["password"];
                    user.IsVet = (bool)dt.Rows[i]["is_vet"];
                    user.Phone = (string)dt.Rows[i]["phone_no"];
                    user.Country = (string)dt.Rows[i]["country"];
                    user.District = (string)dt.Rows[i]["district"];
                    user.City = (string)dt.Rows[i]["city"];
                    user.Address = (string)dt.Rows[i]["address"];
                    Clients.Add(user);
                }

            }
            con.Close();
        }

        public ObservableCollection<User> Clients { get; }
    }
}
