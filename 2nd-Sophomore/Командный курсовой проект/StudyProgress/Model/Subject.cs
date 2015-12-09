using System.Collections.ObjectModel;

namespace Model
{
    public class Subject
    {
        public Subject(string name, Teacher teacher, bool hasExam, bool hasMidterm)
        {
            Name = name;
            Teacher = teacher;
            HasExam = hasExam;
            HasMidterm = hasMidterm;
        }

        public ObservableCollection<Task> Tasks { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public string Summary { get; set; }
        public bool HasExam { get; set; }
        public bool HasMidterm { get; set; }
    }
}
