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
    public partial class CreateProduct : Window
    {
        public CreateProduct(ObservableCollection<Product> products)
        {
            this.products = products;
            InitializeComponent();
        }

        private void CreateProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Insert into [Product] values ( @ProdCode, @Name, @Type, @Price, @Qty); Select max( prod_id ) from [Product];", con);
                cmd.Parameters.AddWithValue("@ProdCode", ProdCode.Text);
                cmd.Parameters.AddWithValue("@Name", Name.Text);
                cmd.Parameters.AddWithValue("@Type", Type.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Qty", Quantity.Text);
                con.Open();
                int id = (int)cmd.ExecuteScalar();
                con.Close();
                Product product = new Product
                {
                    Id = id,
                    ProductCode = ProdCode.Text,
                    Name = Name.Text,
                    Type = int.Parse(Type.Text),
                    Price = double.Parse(Price.Text),
                    Quantity = double.Parse(Quantity.Text),
                };
                products.Add(product);
                MessageBox.Show("Product created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ObservableCollection<Product> products;


    }
}
