using System.Collections.Generic;

namespace Лабораторная_работа__4
{
    abstract class Controller
    {
        // Все записи на прием
        private static List<Admission> admissionList = new List<Admission>();

        // Метод добавления новой записи на прием        
        public static bool addAdmission(string client, string specialist, string time, string aim)
        {
            if (Controller.checkMatches(specialist, time) == false)
            {
                admissionList.Add(new Admission(client, specialist, time, aim));
                return true;
            }
            else
                return false;                
        }

        public static bool checkMatches(string specialist, string time)
        {
            for (int i = 0; i < admissionList.Count; ++i)
            {
                if (admissionList[i].checkMatches(specialist, time))
                    return true;
            }
            return false;
        }

        // Инициализация базы данных клиентов и заполнение начальными объектами
        public static void initClientDB()
        {
            ClientDB cDB = new ClientDB();
            cDB.AddClient(new Client("Mark Zuckerberg", 18567));
            cDB.AddClient(new Client("Pavel Durov", 454431));
            cDB.AddClient(new Client("Sergei Brin", 66354));
        }

        public static List<string> getStringClients()
        {
            List<string> s = new List<string>();
            for (int i = 0; i < ClientDB.getLength(); ++i)
            {
                Client c = ClientDB.getClient(i);
                s.Add(c.getFio() + ", " + c.getCardNumber());
            }
            return s;
        }
    }
}
