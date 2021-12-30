using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using VetApp.Models;
using VetApp.Views;

namespace VetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from [User] where email=@Email and password=@Password", con);
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.Parameters.AddWithValue("@Password", password.Password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0)
            {
                User user = new User();
                user.Id = (int)dt.Rows[0]["user_id"];
                user.Cnp = (string)dt.Rows[0]["cnp"];
                user.FirstName = (string)dt.Rows[0]["first_name"];
                user.LastName = (string)dt.Rows[0]["last_name"];
                user.Email = (string)dt.Rows[0]["email"];
                user.Password = (string)dt.Rows[0]["password"];
                user.IsVet = (bool)dt.Rows[0]["is_vet"];
                user.Phone = (string)dt.Rows[0]["phone_no"];
                user.Country = (string)dt.Rows[0]["country"];
                user.District = (string)dt.Rows[0]["district"];
                user.City = (string)dt.Rows[0]["city"];
                user.Address = (string)dt.Rows[0]["address"];

                if (user.IsVet == true)
                {
                    MainMenu mainMenu = new MainMenu(user);
                    mainMenu.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
            con.Close();
        }
    }
}
