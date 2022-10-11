using RegistrationWindow.Core;
using RegistrationWindow.Model;
using RegistrationWindow.View.Pages;
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

namespace RegistrationWindow
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            
        }

        private void btnLoadPage2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ClientsPage());
        }

        private void btnLoadPage1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ManagersPage());
        }

        private void btnLoadUsers_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AdminsPage());
        }
    }
}