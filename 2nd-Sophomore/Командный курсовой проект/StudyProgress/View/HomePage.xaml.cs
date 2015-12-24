using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SharedModel;
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
            //_dc.Entity.Users.Add(new User()
            //{
            //    Login = "User",
            //    Password = "0000"
            //});

            //_dc.Entity.Subjects.Add(new Subject
            //{
            //    Name = "Матлогика",
            //    ComplitionProgress = 78,
            //    Summary = "Математическая логика и теория алгоритмов"
            //});

            //_dc.Entity.Subjects.Add(new Subject
            //{
            //    Name = "ООП",
            //    ComplitionProgress = 100,
            //    Summary = "Объектно-ориентированное программирование"
            //});

            //_dc.Entity.SaveChanges();

            //var activeUser = new User();
            //var subject1 = new Subject();
            //var subject2 = new Subject();

            //foreach (var t in _dc.Entity.Users.GetAll().Where(t => t.Login == "User"))
            //{
            //    activeUser = t;
            //}

            //foreach (var t in _dc.Entity.Subjects.GetAll().Where(t => t.Name == "Матлогика"))
            //{
            //    subject1 = t;
            //}

            //foreach (var t in _dc.Entity.Subjects.GetAll().Where(t => t.Name == "ООП"))
            //{
            //    subject2 = t;
            //}

            //_dc.AddSubject(activeUser, subject1);
            //_dc.AddSubject(activeUser, subject2);

            //_dc.Entity.SaveChanges();

            var loginPage = new LoginPage();
            var navigationService = NavigationService;
            navigationService?.Navigate(loginPage);
        }
    }
}
