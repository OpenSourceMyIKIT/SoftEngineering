using System.Windows;
using System.Windows.Controls;
using SharedModel;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private readonly MainWindowViewModel _dc = MainWindowViewModel.Instance;

        public MainPage()
        {
            InitializeComponent();
            DataContext = _dc;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            InfoTextBlock.Text = _dc.ReturnName();
        }

        private void ButtonReturnToLogin_Click(object sender, RoutedEventArgs e)
        {
            var homePage = new HomePage();
            var navigationService = NavigationService;
            navigationService?.Navigate(homePage);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            _dc.Close();
            Application.Current.Shutdown();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var t in _dc.Client.ReturnActiveUser().Subjects)
            {
                SubjectsPanel.Children.Add(new TextBlock
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    Margin = new Thickness(10, 10, 10, 10),
                    FontSize = 16,
                    Text = t.Name
                });
                SubjectsPanel.Children.Add(new ProgressBar
                {
                    HorizontalAlignment = HorizontalAlignment.Right,
                    VerticalAlignment = VerticalAlignment.Top,
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(10, 10, 10, 10),
                    Minimum = 0,
                    Maximum = 100,
                    Value = t.Progress,
                    Width = 100,
                    Height = 10
                });
            }
        }
    }
}
