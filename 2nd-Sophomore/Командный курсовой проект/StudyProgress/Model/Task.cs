using System;

namespace Model
{
    public class Task
    {
        public Task(string name, string taskText, DateTime given, DateTime due)
        {
            Name = name;
            TaskText = taskText;
            Given = given;
            Due = due;
        }

        public string Name { get; set; }
        public string TaskText { get; set; }
        public DateTime Given { get; set; }
        public DateTime Due { get; set; }
    }
}
