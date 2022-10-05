using RegistrationWindow.Core;
using System.Linq;
using System.Windows;

namespace RegistrationWindow

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserValidator.Validate(tbLogin.Text, tbPassword.Text, "users3.txt"))
            {

                if (UserParser.Parse("users3.txt").FirstOrDefault(u => u.Login.Equals(tbLogin.Text) && u.Password.Equals(tbPassword.Text)).Role.Equals("Admin"))
                {
                    new UsersWindow().Show();
                    Close();
                }
                if (UserParser.Parse("users3.txt").FirstOrDefault(u => u.Login.Equals(tbLogin.Text) && u.Password.Equals(tbPassword.Text)).Role.Equals("Manager"))
                {
                    MessageBox.Show("Поздравляю, вы менеджер!", "Окошко менеджера", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                if (UserParser.Parse("users3.txt").FirstOrDefault(u => u.Login.Equals(tbLogin.Text) && u.Password.Equals(tbPassword.Text)).Role.Equals("Client"))
                {
                    MessageBox.Show("Поздравляю, вы клиент!", "Окошко клиента", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
            }
            else MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}