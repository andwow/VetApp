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
using VetApp.ViewModels;

namespace VetApp.Views
{
    /// <summary>
    /// Interaction logic for ClientProfile.xaml
    /// </summary>
    public partial class ClientProfile : Window
    {
        public ClientProfile(User user)
        {
            User userCopy = new User(user);
            viewModel = new ClientProfileVM(userCopy);
            DataContext = viewModel;
            InitializeComponent();
        }

        public ClientProfile(ObservableCollection<User> userList, User user)
        {
            this.user = user;
            this.userList = userList;
            User userCopy = new User(user);
            viewModel = new ClientProfileVM(userCopy);
            DataContext = viewModel;
            InitializeComponent();
        }

        private void ResetPassword_Click(object sender, RoutedEventArgs e)
        {
            if (NewPassword.Password != "" && ConfirmPass.Password != "" &&
               NewPassword.Password == ConfirmPass.Password)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Update [User] set password = @Password where user_id = @UserId;", con);
                    cmd.Parameters.AddWithValue("@Password", NewPassword.Password);
                    cmd.Parameters.AddWithValue("@UserId", viewModel.CurrentUser.Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password changed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password fields are not the same or empty.");
            }

        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(
                    "Update [User] set " +
                    "cnp = @Cnp, " +
                    "first_name = @FirstName, " +
                    "last_name = @LastName, " +
                    "email = @Email, " +
                    "phone_no = @Phone, " +
                    "country = @Country, " +
                    "district = @State, " +
                    "city = @City, " +
                    "address = @Address " +
                    "where user_id = @UserId;", con);
                cmd.Parameters.AddWithValue("@Cnp", Cnp.Text);
                cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", LastName.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                cmd.Parameters.AddWithValue("@Country", Country.Text);
                cmd.Parameters.AddWithValue("@State", State.Text);
                cmd.Parameters.AddWithValue("@City", City.Text);
                cmd.Parameters.AddWithValue("@Address", Address.Text);
                cmd.Parameters.AddWithValue("@UserId", viewModel.CurrentUser.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                user = viewModel.CurrentUser;
                MessageBox.Show("Profile mofified!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);

            if (dialogResult == MessageBoxResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Delete from [User] where user_id = @UserId;", con);
                    cmd.Parameters.AddWithValue("@UserId", viewModel.CurrentUser.Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Profile deleted!");
                    this.Close();
                    if (userList != null)
                    {
                        userList.Remove(user);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not deleted:" + ex.Message);
                }
            }
        }
        private void CreatePet_Click(object sender, RoutedEventArgs e)
        {
            CreatePet createPet = new CreatePet(viewModel.Pets, user);
            createPet.Show();
        }

        ClientProfileVM viewModel;
        User user;
        ObservableCollection<User> userList;
    }
}
