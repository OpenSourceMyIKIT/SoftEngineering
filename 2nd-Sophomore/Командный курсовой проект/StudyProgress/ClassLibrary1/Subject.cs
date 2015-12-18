using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Subject
    {
        //public Subject()
        //{
            
        //}
        //public Subject(string name, Teacher teacher, bool hasExam, bool hasMidterm)
        //{
        //    Name = name;
        //    Teacher = teacher;
        //    HasExam = hasExam;
        //    HasMidterm = hasMidterm;
        //}
        [DataMember]
        public ObservableCollection<Task> Tasks { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Teacher Teacher { get; set; }
        [DataMember]
        public string Summary { get; set; }
        [DataMember]
        public bool HasExam { get; set; }
        [DataMember]
        public bool HasMidterm { get; set; }
    }
}
