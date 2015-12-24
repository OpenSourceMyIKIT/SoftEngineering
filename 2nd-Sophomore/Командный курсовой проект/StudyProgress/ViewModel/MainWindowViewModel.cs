using System.Linq;
using SharedModel;
using ViewModel.ServiceReference1;
using EntityUnitOfWork = EntityDAL.UnitOfWork;

namespace ViewModel
{
    public class MainWindowViewModel
    {
        private static MainWindowViewModel _instance;
        //private Service1Client _client;
        private EntityUnitOfWork _entity;

        private MainWindowViewModel()
        {
        }

        public static MainWindowViewModel Instance => _instance ?? (_instance = new MainWindowViewModel());

        //public Service1Client Client => _client ?? (_client = new Service1Client());

        public EntityUnitOfWork Entity => _entity ?? (_entity = new EntityUnitOfWork());
        
        private static User _activeUser;

        public User ReturnActiveUser()
        {
            return _activeUser;
        }

        public bool Login(string login, string password)
        {
            var result = Entity.Users?.GetAll().Any(t => login == t.Login && password == t.Password);

            foreach (var t in Entity.Users.GetAll().Where(t => t.Login == login))
            {
                _activeUser = t;
            }

            return (bool)result;
        }

        public bool Register(string login, string password)
        {
            if (Entity.Users != null)
            {
                if (Entity.Users.GetAll().Any(t => t.Login == login))
                {
                    return false;
                }
            }
            Entity.Users?.Add(new User() { Login = login, Password = password });

            foreach (var t in Entity.Users.GetAll().Where(t => t.Login == login))
            {
                _activeUser = t;
            }

            Entity.SaveChanges();
            return true;
        }

        public void AddSubject(User user, Subject subject)
        {
            user.Subjects.Add(subject);
            Entity.SaveChanges();
        }

        //public string ReturnName()
        //{
        //    return Client.GetSubject().Name;
        //}

        //public void SetExam(bool b)
        //{
        //    Client.SetExam(b);
        //}

        //public void Close()
        //{
        //    Client.Close();
        //}
    }
}
