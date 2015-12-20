using System.Windows;
using System.Windows.Controls;
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

            _dc.SetExam(true);
            _dc.Close();
        }
    }
}
