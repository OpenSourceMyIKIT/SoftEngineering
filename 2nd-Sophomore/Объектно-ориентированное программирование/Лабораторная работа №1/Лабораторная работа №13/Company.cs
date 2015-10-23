using System;
using System.Collections.Generic;

namespace Лабораторная_работа__13
{
    [Serializable]
    public class Company
    {
        private string name;
        private List<Driver> staff;
        private List<Transport> autopark;

        public Company()
        {
            name = null;
            staff = null;
            autopark = null;
        }

        public Company(string name)
        {
            this.name = name;
            this.staff = new List<Driver>();
            this.autopark = new List<Transport>();
        }

        // Свойства
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        // Метод добавления нового водителя в список компании
        public void AddStaff(Driver driver)
        {
            staff.Add(driver);
        }

        // Метод, возвращающий количество водителей в компании
        public string CountStaff()
        {
            return staff.Count.ToString();
        }

        // Аксессор для поля staff
        public List<Driver> Staff
        {
            get { return staff; }
        }

        // Метод добавления нового транспорта в список компании
        public void AddTransport(Transport transport)
        {
            autopark.Add(transport);
        }

        // Метод, возвращающий количество транспорта в автопарке
        public string CountTransport()
        {
            return autopark.Count.ToString();
        }

        // Аксессор для поля autopark
        public List<Transport> Autopark
        {
            get { return autopark; }
        }

        // Метод возвращающий имя компании, которой принадлежит данный транспорт
        public string whoIsOwner (Transport transport)
        {
            foreach (Transport auto in autopark)
            {
                if (transport.Number == auto.Number)
                    return name;
            }
            return null;
        }

        // Метод, возвращающий имя компании, являющейся работодателем для данного водителя
        public string whoIsOwner (Driver driver)
        {
            foreach (Driver d in staff)
            {
                if (d.Fio == driver.Fio)
                    return name;
            }
            return null;
        }
    }
}
