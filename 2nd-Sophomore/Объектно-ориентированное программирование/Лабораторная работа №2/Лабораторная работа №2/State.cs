using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__2
{
    public abstract class State
    {
        protected string name; // Название
        protected string foundation; // Дата основания

        static private List<State> spisok;

        // Пользвательский конструктор
        public State(string name, string foundation)
        {
            this.name = name;
            this.foundation = foundation;
        }

        public static void AddState(State state)
        {
            spisok.Add(state);
        }

        public static State GetState(int index)
        {
            return spisok[index];
        }

        public static int Length()
        {
            return spisok.Count;
        }

        public static void InitSpisok()
        {
            spisok = new List<State>();
        }

        public abstract string Info(); // Возвращает только name

        public abstract string Info(string field); // Возвращает в зависимости от входного параметра
    }
}
