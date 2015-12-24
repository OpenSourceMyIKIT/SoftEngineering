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
        }

        private void BtnAddSubject_Click(object sender, RoutedEventArgs e)
        {
            _dc.AddSubject(_dc.ReturnActiveUser(), new Subject
            {
                Name = TbName.Text,
                HasExam = (bool)CheckExam.IsChecked,
                HasMidterm = (bool)CheckMidterm.IsChecked,
                Summary = TbSummary.Text
            });

            _dc.Entity.SaveChanges();
            var mainPage = new MainPage();
            var navigationService = NavigationService;
            navigationService?.Navigate(mainPage);
        }
    }
}
