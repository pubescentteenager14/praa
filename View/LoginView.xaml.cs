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
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private readonly LoginViewModel viewModel;
        public static LoginView loginView;
        public LoginView()
        {
            InitializeComponent();
            viewModel = new LoginViewModel();
            DataContext = viewModel;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nextPageButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Register());
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Register());
        }
    }
}
