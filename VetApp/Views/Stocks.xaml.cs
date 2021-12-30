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
    /// Interaction logic for Stocks.xaml
    /// </summary>
    public partial class Stocks : Window
    {
        public Stocks()
        {
            viewModel = new StocksVM();
            DataContext = viewModel;
            InitializeComponent();
        }

        private void CreateProduct_Click(object sender, RoutedEventArgs e)
        {
            CreateProduct create = new CreateProduct(viewModel.Products);
            create.Show();
        }
        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        StocksVM viewModel;
    }
}
