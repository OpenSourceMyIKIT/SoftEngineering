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
        private List<User> users = new List<User>()
        {
            new User()
            {
                Login = "User",
                Password = "0000"
            }
        };

        private Subject oop = new Subject {Name = "ООП", HasExam = false};
        

        public string GetData(int value)
        {
            return $"You entered: {value}";
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
            return users.Any(t => login == t.Login && password == t.Password);
        }

        public bool Register(string login, string password)
        {
            if (users.Any(t => t.Login == login))
            {
                return false;
            }
            users.Add(new User() {Login = login, Password = password});
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
