using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__5
{
    // Клиент больницы
    public class Client
    {
        private string _fio;
        private int _cardNumber;

        public string getFio()
        {
            return _fio;
        }

        public int getCardNumber()
        {
            return _cardNumber;
        }

        public Client(string fio, int cardNumber)
        {
            _fio = fio;
            _cardNumber = cardNumber;
        }

        public Client getClient()
        {
            return this;
        }
    }
}
