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
    /// Interaction logic for PetScreen.xaml
    /// </summary>
    public partial class PetScreen : Window
    {
        public PetScreen(Pet pet, bool canModify, Cart cart, int vetId)
        {
            this.vetId = vetId;
            this.cart = cart;
            this.canModify = canModify;
            viewModel = new PetScreenVM(pet);
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            if (canModify)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(
                        "Update [Pet] set " +
                        "personal_code = @PersCode, " +
                        "name = @Name, " +
                        "birthday = @Birthday, " +
                        "gender = @Gender, " +
                        "species = @Species, " +
                        "breed = @Breed, " +
                        "color = @Color, " +
                        "marks = @Marks " +
                        "where pet_id = @Id;", con);
                    cmd.Parameters.AddWithValue("@PersCode", PersonalCode.Text);
                    cmd.Parameters.AddWithValue("@Name", Name.Text);
                    cmd.Parameters.AddWithValue("@Birthday", Birthday.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                    cmd.Parameters.AddWithValue("@Species", Species.Text);
                    cmd.Parameters.AddWithValue("@Breed", Breed.Text);
                    cmd.Parameters.AddWithValue("@Color", Color.Text);
                    cmd.Parameters.AddWithValue("@Marks", Marks.Text);
                    cmd.Parameters.AddWithValue("@Id", viewModel.CurrentPet.Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Pet mofified!");
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

        PetScreenVM viewModel;
        readonly bool canModify;

        private void AddVaccine_Click(object sender, RoutedEventArgs e)
        {
            if (vetId != 0)
            {
                AddIntervention addIntervention = new AddIntervention(1, cart, viewModel.CurrentPet.Id, vetId);
                addIntervention.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can add interventions");
            }
        }

        private void AddDeparasitation_Click(object sender, RoutedEventArgs e)
        {
            if (vetId != 0)
            {
                AddIntervention addIntervention = new AddIntervention(2, cart, viewModel.CurrentPet.Id, vetId);
                addIntervention.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can add interventions");
            }
        }

        private void AddTreatment_Click(object sender, RoutedEventArgs e)
        {
            if (vetId != 0)
            {
                AddIntervention addIntervention = new AddIntervention(3, cart, viewModel.CurrentPet.Id, vetId);
                addIntervention.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can add interventions");
            }
        }

        private void AddOperation_Click(object sender, RoutedEventArgs e)
        {
            if (vetId != 0)
            {
                AddIntervention addIntervention = new AddIntervention(4, cart, viewModel.CurrentPet.Id, vetId);
                addIntervention.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can add interventions");
            }
        }

        int vetId;
        private Cart cart;

        private void MyCart_Click(object sender, RoutedEventArgs e)
        {
            MyCart myCart = new MyCart(cart);
            myCart.Show();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Refresh();
        }

        private void ViewVaccine_Click(object sender, RoutedEventArgs e)
        {
                Interventions interventions = new Interventions(1, cart, viewModel.CurrentPet.Id, vetId);
                interventions.Show();
        }

        private void ViewDeparasitation_Click(object sender, RoutedEventArgs e)
        {
                Interventions interventions = new Interventions(2, cart, viewModel.CurrentPet.Id, vetId);
                interventions.Show();
        }

        private void ViewTreatment_Click(object sender, RoutedEventArgs e)
        {
                Interventions interventions = new Interventions(3, cart, viewModel.CurrentPet.Id, vetId);
                interventions.Show();
        }

        private void ViewOperation_Click(object sender, RoutedEventArgs e)
        {
                Interventions interventions = new Interventions(4, cart, viewModel.CurrentPet.Id, vetId);
                interventions.Show();
        }
    }
}
