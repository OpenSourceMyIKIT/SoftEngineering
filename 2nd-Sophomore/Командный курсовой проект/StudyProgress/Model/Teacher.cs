using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Teacher
    {
        public Teacher(string name)
        {
            Name = name;
        }

        [DataMember]
        public string Name { get; set; }
    }
}
