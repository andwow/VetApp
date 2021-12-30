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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VetApp.Models;
using VetApp.ViewModels;

namespace VetApp.Views
{
    /// <summary>
    /// Interaction logic for ProductScreen.xaml
    /// </summary>
    public partial class ProductScreen : Window
    {
        public ProductScreen(ObservableCollection<Product> productList, Product product)
        {
            viewModel = new ProductScreenVM(product);
            DataContext = viewModel;
            currentProduct = product;
            this.productList = productList;
            InitializeComponent();
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);

            if (dialogResult == MessageBoxResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Delete from [Product] where prod_id = @ProdId;", con);
                    cmd.Parameters.AddWithValue("@ProdId", viewModel.CurrentProduct.Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product deleted!");
                    this.Close();
                    if (productList != null)
                    {
                        productList.Remove(currentProduct);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not deleted: " + ex.Message);
                }
            }
        }

        private void ModifyProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(
                    "Update [Product] set " +
                    "prod_code = @ProdCode, " +
                    "prod_name = @ProdName, " +
                    "type = @Type, " +
                    "price = @Price, " +
                    "quantity = @Qty " +
                    "where prod_id = @ProdId;", con);
                cmd.Parameters.AddWithValue("@ProdCode", ProdCode.Text);
                cmd.Parameters.AddWithValue("@ProdName", Name.Text);
                cmd.Parameters.AddWithValue("@Type", Type.Text);
                cmd.Parameters.AddWithValue("@Price", Price.Text);
                cmd.Parameters.AddWithValue("@Qty", Quantity.Text);
                cmd.Parameters.AddWithValue("@ProdId", currentProduct.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                currentProduct.ProductCode = ProdCode.Text;
                currentProduct.Name = Name.Text;
                currentProduct.Type = int.Parse(Type.Text);
                currentProduct.Price = double.Parse(Price.Text);
                currentProduct.Quantity = double.Parse(Quantity.Text);
                MessageBox.Show("Product mofified!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Product currentProduct;
        ObservableCollection<Product> productList;
        ProductScreenVM viewModel;
    }
}
