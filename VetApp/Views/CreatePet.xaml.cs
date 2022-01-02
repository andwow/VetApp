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
    /// Interaction logic for CreatePet.xaml
    /// </summary>
    public partial class CreatePet : Window
    {
        public CreatePet(ObservableCollection<Pet> pets, User owner)
        {
            this.pets = pets;
            this.owner = owner;
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                StringBuilder birthday = new StringBuilder();
                birthday.Append(BirthdayYear.Text);
                birthday.Append("-");
                birthday.Append(BirthdayMonth.Text);
                birthday.Append("-");
                birthday.Append(BirthdayDay.Text);
                SqlCommand cmd = new SqlCommand("Insert into [Pet] values ( @PersCode, @Name, @Birthday, @Gender, @Species, @Breed, @Color, @Marks, @Owner); Select max( pet_id ) from [Pet];", con);
                cmd.Parameters.AddWithValue("@PersCode", PersonalCode.Text);
                cmd.Parameters.AddWithValue("@Name", Name.Text);
                cmd.Parameters.AddWithValue("@Birthday", birthday.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                cmd.Parameters.AddWithValue("@Species", Species.Text);
                cmd.Parameters.AddWithValue("@Breed", Breed.Text);
                cmd.Parameters.AddWithValue("@Color", Color.Text);
                cmd.Parameters.AddWithValue("@Marks", Marks.Text);
                cmd.Parameters.AddWithValue("@Owner", owner.Id);
                con.Open();
                int id = (int)cmd.ExecuteScalar();
                con.Close();
                Pet pet = new Pet()
                {
                    Id = id,
                    PersonalCode = PersonalCode.Text,
                    Name = Name.Text,
                    Birthday = DateTime.Parse(birthday.ToString()),
                    Gender = Gender.Text,
                    Species = Species.Text,
                    Breed = Breed.Text,
                    Color = Color.Text,
                    Marks = Marks.Text
                };
                pets.Add(pet);
                MessageBox.Show("Pet created!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ObservableCollection<Pet> pets;
        User owner;
    }
}
