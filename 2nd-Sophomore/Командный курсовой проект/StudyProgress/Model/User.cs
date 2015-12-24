using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class User : IDomainObject
    {
        [DataMember]
        public string Login { get; set; } 
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public virtual ICollection<Subject> Subjects { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}