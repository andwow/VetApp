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
using VetApp.ViewModels;

namespace VetApp.Views
{
    /// <summary>
    /// Interaction logic for AllSales.xaml
    /// </summary>
    public partial class AllSales : Window
    {
        public AllSales()
        {
            viewModel = new AllSalesVM();
            DataContext = viewModel;
            InitializeComponent();
        }
        AllSalesVM viewModel;

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (viewModel.StartDate <= viewModel.EndDate)
                {
                    viewModel.Search(viewModel.StartDate, viewModel.EndDate);
                    Total.Text = viewModel.TotalPriceStr;
                }
                else
                {
                    MessageBox.Show("Start date lower than end date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
