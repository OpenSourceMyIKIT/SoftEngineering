using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__5
{
    // База данных клиентов
    public class ClientDB
    {
        private static List<Client> clientDataBase = new List<Client>();

        public void AddClient(Client c)
        {
            clientDataBase.Add(c);
        }

        public static Client getClient(int index)
        {
            return clientDataBase[index].getClient();
        }

        public static int getLength()
        {
            return clientDataBase.Count;
        }
    }
}
