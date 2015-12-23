using ViewModel.ServiceReference1;

namespace ViewModel
{
    public class MainWindowViewModel
    {
        private static MainWindowViewModel _instance;
        private Service1Client _client;

        private MainWindowViewModel()
        {
        }

        public static MainWindowViewModel Instance => _instance ?? (_instance = new MainWindowViewModel());

        public Service1Client Client => _client ?? (_client = new Service1Client());

        public string ReturnName()
        {
            return Client.GetSubject().Name;
        }

        public void SetExam(bool b)
        {
            Client.SetExam(b);
        }

        public void Close()
        {
            Client.Close();
        }
    }
}
