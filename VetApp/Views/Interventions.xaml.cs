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
    /// Interaction logic for Interventions.xaml
    /// </summary>
    public partial class Interventions : Window
    {
        public Interventions(int intvType, Cart cart, int petId, int vetId)
        {
            InitializeComponent();
            viewModel = new InterventionsVM(intvType, petId);
            DataContext = viewModel;
            switch(intvType)
            {
                case 1:
                    Title = "Vaccines";
                    AddIntervention.Content = "Add vaccine";
                    break;
                case 2:
                    Title = "Deparasitations";
                    AddIntervention.Content = "Add deparasitation";
                    break;
                case 3:
                    Title = "Treatments";
                    AddIntervention.Content = "Add treatment";
                    break;
                case 4:
                    Title = "Operations";
                    AddIntervention.Content = "Add operation";
                    break;
                default:
                    Title = "Operations";
                    AddIntervention.Content = "Add operation";
                    break;
            }
            this.vetId = vetId;
            this.cart = cart;
        }

        private void AddIntervention_Click(object sender, RoutedEventArgs e)
        {
            if (vetId != 0)
            {
                AddIntervention addIntervention = new AddIntervention(viewModel.IntvType, cart, viewModel.PetId, vetId);
                addIntervention.Show();
            }
            else
            {
                MessageBox.Show("Just a vet can add interventions.");
            }
        }

        private readonly Cart cart;
        readonly int vetId;
        InterventionsVM viewModel;

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Refresh();
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
                        Intervention dr = (Intervention)dgr.Item;
                        InterventionDetails profile = new InterventionDetails(dr);
                        profile.Show();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
