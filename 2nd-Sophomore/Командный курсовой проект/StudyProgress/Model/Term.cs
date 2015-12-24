using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Term : IDomainObject
    {
        [DataMember]
        public List<Subject> Subjects { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}
