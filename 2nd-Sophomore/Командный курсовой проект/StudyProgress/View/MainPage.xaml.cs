using System.Collections.Generic;
using System.Linq;
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
            DataContext = _dc.ReturnActiveUser().Subjects.ToList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var addSubject = new AddSubject();
            var navigationService = NavigationService;
            navigationService?.Navigate(addSubject);
        }

        private void ButtonReturnToLogin_Click(object sender, RoutedEventArgs e)
        {
            var homePage = new HomePage();
            var navigationService = NavigationService;
            navigationService?.Navigate(homePage);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var t in _dc.ReturnActiveUser().Subjects)
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
                    Value = t.ComplitionProgress,
                    Width = 100,
                    Height = 10,
                    ToolTip = new ToolTip { Content = t.ComplitionProgress + "%" }
                });
            }
        }
    }
}
