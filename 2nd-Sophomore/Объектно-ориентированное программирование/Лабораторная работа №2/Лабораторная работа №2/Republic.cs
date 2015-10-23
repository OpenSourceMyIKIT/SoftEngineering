namespace Лабораторная_работа__2
{
    public class Republic : State
    {
        private string government; // Орган управления
        static private string sourceOfLaw = "Nation"; // Во всех республиках источник власти - народ

        // Пользовательский конструктор, который вызвает к конструктору базового класса
        public Republic(string name, string foundation, string government)
            :base(name, foundation)
        {
            this.government = government;
        }

        public override string Info()
        {
            return name;
        }

        public override string Info(string field)
        {
            if (field.ToLower() == "name")
                return name;
            else if (field.ToLower() == "foundation")
                return foundation;
            else if (field.ToLower() == "government")
                return government;
            else if (field.ToLower() == "sourceoflaw")
                return sourceOfLaw;
            else return "";
        }
    }
}
