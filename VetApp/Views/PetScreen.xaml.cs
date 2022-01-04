using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public PetScreen(Pet pet)
        {
            viewModel = new PetScreenVM(pet);
            DataContext = viewModel;
            InitializeComponent();
        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {

        }

        private PetScreenVM viewModel;
    }
}
