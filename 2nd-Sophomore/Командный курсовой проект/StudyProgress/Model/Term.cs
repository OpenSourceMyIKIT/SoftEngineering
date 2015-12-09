using System.Collections.ObjectModel;

namespace Model
{
    public class Term
    {
        public ObservableCollection<Subject> Subjects { get; set; }
        public int Year { get; set; }
    }
}
