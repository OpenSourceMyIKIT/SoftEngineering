using System.Windows;
using System.Windows.Controls;
using SharedModel;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for AddSubject.xaml
    /// </summary>
    public partial class AddSubject : Page
    {
        private readonly MainWindowViewModel _dc = MainWindowViewModel.Instance;

        public AddSubject()
        {
            InitializeComponent();
            DataContext = _dc;
        }

        private void BtnAddSubject_Click(object sender, RoutedEventArgs e)
        {
            //_dc.Client.AddSubject(_dc.Client.ReturnActiveUser(), new Subject
            //{
            //    Name = TbName.Text,
            //    HasExam = (bool)CheckExam.IsChecked,
            //    HasMidterm = (bool)CheckMidterm.IsChecked,
            //    Summary = TbSummary.Text
            //});
            var mainPage = new MainPage();
            var navigationService = NavigationService;
            navigationService?.Navigate(mainPage);
        }
    }
}
