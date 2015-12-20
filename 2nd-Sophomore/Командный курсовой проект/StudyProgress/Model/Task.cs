using System;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Task
    {
        public Task(string name, string taskText, DateTime given, DateTime due)
        {
            Name = name;
            TaskText = taskText;
            Given = given;
            Due = due;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string TaskText { get; set; }
        [DataMember]
        public DateTime Given { get; set; }
        [DataMember]
        public DateTime Due { get; set; }
    }
}
