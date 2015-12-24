using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Subject : IDomainObject
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
        public List<Task> Tasks { get; set; }
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
        [DataMember]
        public int ComplitionProgress { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public virtual User User { get; set; }
    }
}
