using System;

namespace Лабораторная_работа__13
{
    [Serializable]
    public class Transport
    {
        private string number; // Номер
        private int route;  // Маршрут
        private string model;   // Модель
        private Driver driver; // Водитель

        // Конструктор по умолчанию класса Transport
        public Transport()
        {
            number = null;
            route = 0;
            model = null;
            driver = null;
        }

        // Перегруженный конструктор класса Transport
        public Transport(string number, int route, string model)
        {
            this.number = number;
            this.route = route;
            this.model = model;
            this.driver = null;
        }

        // Свойства
        public string Number
        {
            set { number = value; }
            get { return number; }
        }

        public int Route
        {
            set { route = value; }
            get { return route; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public Driver Driver
        {
            set { driver = value; }
            get { return driver; }
        }

        // Функция заполнение ListView списком пациентов выбранного доктора 
        //public static void FillListView(ref ListView lv, ref List<Driver> docPatients, int index)
        //{
        //    foreach (Driver pat in docPatients)
        //    {
        //        ListViewItem lvi = new ListViewItem(pat.FIO);
        //        lvi.SubItems.Add(pat.age.ToString());
        //        lvi.SubItems.Add(pat.gender);
        //        lv.Items.Add(lvi);
        //    }
        //}
    }
}
