using System;

namespace Лабораторная_работа__13
{
    [Serializable]
    public class Driver
    {
        private string fio;
        private string category;
        private Transport machine;

        // Конструктор класса Driver
        public Driver()
        {
            fio = null;
            category = null;
            machine = null;
        }

        // Перегруженный конструктор класса Driver
        public Driver(string fio, string category)
        {
            this.fio = fio;
            this.category = category;
            this.machine = null;
        }

        // Свойства
        public string Fio
        {
            set { fio = value; }
            get { return fio; }
        }

        public string Category
        {
            set { category = value; }
            get { return category; }
        }

        public Transport Machine
        {
            set { machine = value; }
            get { return machine; }
        }

        //// Функция заполнения ListView списком докторов выбранного пациента
        //public static void FillListView(ref ListView lv, ref List<Transport> patDoctors, int index)
        //{
        //    foreach (Transport doc in patDoctors)
        //    {
        //        ListViewItem lvi = new ListViewItem(doc.FIO);
        //        lvi.SubItems.Add(doc.specialization);
        //        lvi.SubItems.Add(doc.cabinet);
        //        lv.Items.Add(lvi);
        //    }
        //}


    }
}
