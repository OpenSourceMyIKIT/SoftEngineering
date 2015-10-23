using System;

namespace Лабораторная_работа__2
{
    public class Kingdom : Monarchy
    {
        // Пользовательский конструктор, который вызывает к конструктору базового класса
        public Kingdom(string name, string foundation, string monarch)
            :base(name, foundation, "Король " + monarch, true)
        {

        }
        

    }
}
