using System.Collections.Generic;

namespace Лабораторная_работа__4
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
