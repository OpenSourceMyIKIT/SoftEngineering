using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace SharedModel
{
    [DataContract]
    public class Term
    {
        [DataMember]
        public ObservableCollection<Subject> Subjects { get; set; }
        [DataMember]
        public int Year { get; set; }
    }
}
