using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private readonly MainWindowViewModel _dc = MainWindowViewModel.Instance;

        public HomePage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var loginPage = new LoginPage();
            var navigationService = NavigationService;
            navigationService?.Navigate(loginPage);
        }
    }
}
