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
        public ClientProfile(User user, bool canModify, int vetId)
        {
            this.vetId = vetId;
            cart = new Cart();
            this.canModify = canModify;
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
            if (canModify == true)
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
            else
            {
                MessageBox.Show("Just a vet can modify!");
            }
        }

        //private void Delete_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBoxResult dialogResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);

        //    if (dialogResult == MessageBoxResult.Yes)
        //    {
        //        try
        //        {
        //            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
        //            SqlCommand cmd = new SqlCommand("Delete from [User] where user_id = @UserId;", con);
        //            cmd.Parameters.AddWithValue("@UserId", viewModel.CurrentUser.Id);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            MessageBox.Show("Profile deleted!");
        //            this.Close();
        //            if (userList != null)
        //            {
        //                userList.Remove(user);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Not deleted:" + ex.Message);
        //        }
        //    }
        //}
        private void CreatePet_Click(object sender, RoutedEventArgs e)
        {
            if (canModify == true)
            {
                CreatePet createPet = new CreatePet(viewModel.Pets, user);
                createPet.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can add pets.");
            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    DataGrid grid = sender as DataGrid;
                    if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                    {
                        //This is the code which helps to show the data when the row is double clicked.
                        DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                        Pet dr = (Pet)dgr.Item;
                        PetScreen profile = new PetScreen(dr, canModify, cart, vetId);
                        profile.Show();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        int vetId;
        ClientProfileVM viewModel;
        User user;
        readonly bool canModify;

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Refresh();
        }

        private Cart cart;

        private void MyCart_Click(object sender, RoutedEventArgs e)
        {
            if (canModify)
            {
                MyCart myCart = new MyCart(cart);
                myCart.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can see your cart");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            con.Open();
            foreach (Items item in cart.Items)
            {
                SqlCommand cmd = new SqlCommand("Update [Product] set quantity += @Qty where prod_id = @ProdId;", con);
                cmd.Parameters.AddWithValue("@Qty", item.Quantity);
                cmd.Parameters.AddWithValue("@ProdId", item.ProductId);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
