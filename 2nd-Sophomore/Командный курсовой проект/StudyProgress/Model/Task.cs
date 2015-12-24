using System;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Task : IDomainObject
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string TaskText { get; set; }
        [DataMember]
        public DateTime Given { get; set; }
        [DataMember]
        public DateTime Due { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}
