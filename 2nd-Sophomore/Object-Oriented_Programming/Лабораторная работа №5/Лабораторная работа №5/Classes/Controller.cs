using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__5
{
    abstract class Controller
    {
        // Рекомендация: не создавать фабрику каждый раз, а сделать ее статическим полем и только настраивать

        // Все записи на прием
        private static List<Admission> admissionList = new List<Admission>();

        // Метод добавления новой записи на прием        
        public static bool addAdmission(string client, string specialist, string time, string aim)
        {
            // Создание и настройка фабрики
            AdmissionFactory adFactory = new AdmissionFactory();
            adFactory.SetSpecialist(specialist);
            adFactory.SetTime(time);
            adFactory.SetClient(client);
            adFactory.SetAim(aim);

            // Проверка на занятость специалиста
            if (Controller.checkMatches(specialist, time) == false)
            {
                // Создание и занесение в список новой записи
                admissionList.Add(adFactory.CreateAdmission());
                return true;
            }
            else
                return false;                
        }

        // Проверка на на занятость специалиста по времени
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

        // Возвращение базы клиентов в виде списка строк
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
