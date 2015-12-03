using System;

namespace Лабораторная_работа__2
{
    public class Monarchy : State
    {
        protected string monarch; // Монарх
        protected Boolean powerInhereted; // Передается ли власть по наследству

        // Пользовательский конструктор, который вызывает к конструктору базового класса
        public Monarchy(string name, string foundation, string monarch, Boolean powerInhereted)
            :base(name, foundation)
        {
            this.monarch = monarch;
            this.powerInhereted = powerInhereted;
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
            else if (field.ToLower() == "monarch")
                return monarch;
            else if (field.ToLower() == "powerinhereted")
                return powerInhereted.ToString();
            else return "";
        }
    }
}
