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
    /// Interaction logic for MyCart.xaml
    /// </summary>
    public partial class MyCart : Window
    {
        public MyCart(Cart cart)
        {
            viewModel = new MyCartVM(cart);
            DataContext = viewModel;
            InitializeComponent();
        }
        MyCartVM viewModel;

        private void PlaceInterventions_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into [Intervention] values ( @Pet, @Vet, @Name, @Type, @Date, @NextDate, @Price); Select max ( intv_id ) from [Intervention];", con))
                {
                    foreach (Intervention intv in viewModel.MyCart.Interventions)
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        {
                            cmd.Parameters.AddWithValue("@Pet", intv.Pet);
                            cmd.Parameters.AddWithValue("@Vet", intv.Vet);
                            cmd.Parameters.AddWithValue("@Name", intv.Name);
                            cmd.Parameters.AddWithValue("@Type", intv.Type);
                            cmd.Parameters.AddWithValue("@Date", intv.Date);
                            cmd.Parameters.AddWithValue("@NextDate", intv.NextDate);
                            cmd.Parameters.AddWithValue("@Price", intv.Price);
                        }
                        int intvId = (int)cmd.ExecuteScalar();
                        using (SqlCommand cmdItms = new SqlCommand("Insert into [Items] values ( @ProdName, @Type, @Qty, @Price, @ProdId, @IntvId);", con))
                        {
                            foreach (Items itms in viewModel.MyCart.Items)
                            {
                                if (itms.InterventionId == intv.Id)
                                {
                                    cmdItms.CommandType = System.Data.CommandType.Text;
                                    {
                                        cmdItms.Parameters.AddWithValue("@ProdName", itms.Name);
                                        cmdItms.Parameters.AddWithValue("@Type", itms.Type);
                                        cmdItms.Parameters.AddWithValue("@Qty", itms.Quantity);
                                        cmdItms.Parameters.AddWithValue("@Price", itms.Price);
                                        cmdItms.Parameters.AddWithValue("@ProdId", itms.ProductId);
                                        cmdItms.Parameters.AddWithValue("@IntvId", intvId);
                                    }
                                    cmdItms.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                this.Close();
                MessageBox.Show("Interventions were placed!");
            }
        }

        private void RefreshPrice()
        {
            double totalPrice = 0;
            foreach (Intervention intv in viewModel.MyCart.Interventions)
            {
                double intvPrice = 0;
                foreach (Items itms in viewModel.MyCart.Items)
                {
                    if (itms.InterventionId == intv.Id)
                    {
                        intvPrice += itms.Price * itms.Quantity;
                    }
                }
                totalPrice += intvPrice;
                intv.Price = intvPrice;
                Interventions.Items.Refresh();
            }
            viewModel.MyCart.TotalPrice = totalPrice;
            Price.Text = totalPrice.ToString();
        }

        private void UsedProducts_CurrentCellChanged(object sender, EventArgs e)
        {
            RefreshPrice();
        }

        private void UsedProducts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    DataGrid grid = sender as DataGrid;
                    if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1 && grid.CurrentColumn.Header.ToString() != "Quantity")
                    {
                        //This is the code which helps to show the data when the row is double clicked.
                        DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                        Items dr = (Items) dgr.Item;
                        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update [Product] set quantity += @Qty where prod_id = @ProdId;", con);
                        cmd.Parameters.AddWithValue("@Qty", dr.Quantity);
                        cmd.Parameters.AddWithValue("@ProdId", dr.ProductId);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        int noOfItems = 0;
                        foreach(Items item in viewModel.MyCart.Items)
                        {
                            if(item.InterventionId == dr.InterventionId)
                            {
                                ++noOfItems;
                            }
                        }
                        if (noOfItems == 1)
                        {
                            foreach (Intervention intervention in viewModel.MyCart.Interventions.ToList())
                            {
                                if (intervention.Id == dr.InterventionId)
                                {
                                    viewModel.MyCart.Interventions.Remove(intervention);
                                }
                            }
                        }
                        viewModel.MyCart.Items.Remove(dr);
                        RefreshPrice();
                       
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Interventions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
                    con.Open();
                    DataGrid grid = sender as DataGrid;
                    if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1 && grid.CurrentColumn.Header.ToString() != "Name" && grid.CurrentColumn.Header.ToString() != "Next date")
                    {
                        //This is the code which helps to show the data when the row is double clicked.
                        DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;

                        Intervention dr = (Intervention)dgr.Item;
                        viewModel.MyCart.TotalPrice -= dr.Price;
                        Price.Text = viewModel.MyCart.TotalPrice.ToString();
                        foreach (Items item in viewModel.MyCart.Items.ToList())
                        {
                            if (item.InterventionId == dr.Id)
                            {
                                SqlCommand cmd = new SqlCommand("Update [Product] set quantity += @Qty where prod_id = @ProdId;", con);
                                cmd.Parameters.AddWithValue("@Qty", item.Quantity);
                                cmd.Parameters.AddWithValue("@ProdId", item.ProductId);
                                cmd.ExecuteNonQuery();

                                viewModel.MyCart.Items.Remove(item);
                            }
                        }
                        viewModel.MyCart.Interventions.Remove(dr);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
