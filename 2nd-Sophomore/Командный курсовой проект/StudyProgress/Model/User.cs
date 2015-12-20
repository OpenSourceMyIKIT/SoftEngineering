using System.Collections.ObjectModel;

namespace SharedModel
{
    public class User
    {
        public string Login { get; set; } 
        public string Password { get; set; }

        public ObservableCollection<Subject> Subjects = new ObservableCollection<Subject>();
    }
}