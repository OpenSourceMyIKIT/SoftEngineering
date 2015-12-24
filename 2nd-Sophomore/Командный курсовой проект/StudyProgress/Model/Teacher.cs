using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Teacher : IDomainObject
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}
