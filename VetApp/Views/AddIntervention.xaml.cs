using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddVaccine.xaml
    /// </summary>
    public partial class AddIntervention : Window
    {
        public AddIntervention(int intvType)
        {
            this.intvType = intvType;
            viewModel = new AddInterventionVM(intvType);
            DataContext = viewModel;
            InitializeComponent();
        }

        private void AvailableProducts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
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
                        Product dr = new Product((Product)dgr.Item);
                        foreach(Product product in viewModel.UsedProducts)
                        {
                            if (product.Id == dr.Id)
                            {
                                ++product.Quantity;
                                viewModel.CurrentIntervention.Price += product.Price;
                                UsedProducts.Items.Refresh();
                                Price.Text = viewModel.CurrentIntervention.Price.ToString();
                                return;
                            }
                        }
                        dr.Quantity = 1;
                        viewModel.CurrentIntervention.Price += dr.Price;
                        Price.Text = viewModel.CurrentIntervention.Price.ToString();
                        viewModel.UsedProducts.Add(dr);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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
                        Product dr = (Product)dgr.Item;
                        viewModel.CurrentIntervention.Price -= dr.Price * dr.Quantity;
                        viewModel.UsedProducts.Remove(dr);
                        Price.Text = viewModel.CurrentIntervention.Price.ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        AddInterventionVM viewModel;
        int intvType;

        private void UsedProducts_CurrentCellChanged(object sender, EventArgs e)
        {
            double price = 0;
            foreach (Product product in viewModel.UsedProducts)
            {
                price += product.Price * product.Quantity;
            }
            viewModel.CurrentIntervention.Price = price;
            Price.Text = viewModel.CurrentIntervention.Price.ToString();
        }
    }
}
