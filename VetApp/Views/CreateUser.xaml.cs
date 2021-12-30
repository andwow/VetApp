using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VetApp.Models;

namespace VetApp.Views
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser(bool isVet)
        {
            InitializeComponent();
            this.isVet = isVet;
        }

        public CreateUser(ObservableCollection<User> userList, bool isVet)
        {
            InitializeComponent();
            this.userList = userList;
            this.isVet = isVet;
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Password.Password == ConfirmPass.Password && Password.Password != "")
                {
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("Insert into [User] values ( @Cnp, @FirstName, @LastName, @Email, @Password, @Phone, @Country, @State, @City, @Address, @IsVet); Select max( user_id ) from [User];", con))
                        {
                            cmd.CommandType = System.Data.CommandType.Text;
                            {
                                cmd.Parameters.AddWithValue("@Cnp", Cnp.Text);
                                cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                                cmd.Parameters.AddWithValue("@LastName", LastName.Text);
                                cmd.Parameters.AddWithValue("@Email", Email.Text);
                                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                                cmd.Parameters.AddWithValue("@Country", Country.Text);
                                cmd.Parameters.AddWithValue("@State", State.Text);
                                cmd.Parameters.AddWithValue("@City", City.Text);
                                cmd.Parameters.AddWithValue("@Address", Address.Text);
                                cmd.Parameters.AddWithValue("@Password", Password.Password);
                                cmd.Parameters.AddWithValue("@IsVet", isVet);

                                int id = Convert.ToInt32(cmd.ExecuteScalar());
                                if (userList != null)
                                {
                                    User user = new User
                                    {
                                        Id = id,
                                        Cnp = Cnp.Text,
                                        FirstName = FirstName.Text,
                                        LastName = LastName.Text,
                                        Email = Email.Text,
                                        Phone = Phone.Text,
                                        Country = Country.Text,
                                        District = State.Text,
                                        City = City.Text,
                                        Address = Address.Text,
                                        Password = Password.Password,
                                        IsVet = isVet,
                                    };

                                    userList.Add(user);
                                }
                                MessageBox.Show("User created!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect passord!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ObservableCollection<User> userList;
        bool isVet;
    }
}
