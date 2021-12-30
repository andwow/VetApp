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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu(User user)
        {
            viewModel = new MainMenuVM(user);
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile(viewModel.ConnectedUser);
            profile.Show();
        }

        MainMenuVM viewModel;

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void Stocks_Click(object sender, RoutedEventArgs e)
        {
            Stocks stocks = new Stocks();
            stocks.Show();
        }
    }
}
