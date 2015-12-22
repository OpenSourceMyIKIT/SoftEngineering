using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly MainWindowViewModel _dc = MainWindowViewModel.Instance;

        public LoginPage()
        {
            InitializeComponent();
            DataContext = _dc;
        }

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (_dc.Client.Login(TbLogin.Text, TbPassword.Text))
            {
                var mainPage = new MainPage();
                var navigationService = NavigationService;
                navigationService?.Navigate(mainPage);
            }
            else MessageBox.Show("Неверная пара логин/пароль!");
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (_dc.Client.Register(TbLogin.Text, TbPassword.Text))
            {
                var mainPage = new MainPage();
                var navigationService = NavigationService;
                navigationService?.Navigate(mainPage);
            }
            else MessageBox.Show("Логин уже занят!");
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            _dc.Close();
            Application.Current.Shutdown();
        }
    }
}
