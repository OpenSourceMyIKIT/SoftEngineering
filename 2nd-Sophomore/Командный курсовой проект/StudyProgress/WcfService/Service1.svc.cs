using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SharedModel;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private List<User> _users = new List<User>()
        {
            new User()
            {
                Login = "User",
                Password = "0000",
                Subjects = new ObservableCollection<Subject>
                {
                    new Subject
                    {
                        Name = "Матлогика",
                        Progress = 78,
                        Summary = "Математическая логика и теория алгоритмов"
                    },
                    new Subject
                    {
                        Name = "ООП",
                        Progress = 100,
                        Summary = "Объектно-ориентированное программирование"
                    }
                }
            }
        };

        private Subject oop = new Subject {Name = "ООП", HasExam = false};

        private static User _activeUser;

        public User ReturnActiveUser()
        {
            return _activeUser;
        }

        public Subject GetSubject()
        {
            return oop;
        }

        public void SetExam(bool b)
        {
            oop.HasExam = b;
        }

        public void AddSubject(User user, Subject subject)
        {
            user.Subjects.Add(subject);
        }

        public bool Login(string login, string password)
        {
            var result = _users.Any(t => login == t.Login && password == t.Password);

            _activeUser = _users.Find(x => x.Login.Contains(login));

            return result;
        }

        public bool Register(string login, string password)
        {
            if (_users.Any(t => t.Login == login))
            {
                return false;
            }
            _users.Add(new User() {Login = login, Password = password});

            _activeUser = _users.Find(x => x.Login.Contains(login));

            return true;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException(nameof(composite));
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
