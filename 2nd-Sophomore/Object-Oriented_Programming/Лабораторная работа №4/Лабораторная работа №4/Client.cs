namespace Лабораторная_работа__4
{
    // Клиент больницы
    public class Client
    {
        private string fio;
        private int cardNumber;

        public string getFio()
        {
            return fio;
        }

        public int getCardNumber()
        {
            return cardNumber;
        }

        public Client(string fio, int cardNumber)
        {
            this.fio = fio;
            this.cardNumber = cardNumber;
        }

        public Client getClient()
        {
            return this;
        }
    }
}
