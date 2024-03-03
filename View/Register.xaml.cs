using Practika1.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practika1.View
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public static Register register;
        private readonly LoginViewModel viewModel;
        public Register()
        {
            InitializeComponent();
            register = this;
            viewModel = new LoginViewModel();
            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new LoginView());
        }
    }
}
