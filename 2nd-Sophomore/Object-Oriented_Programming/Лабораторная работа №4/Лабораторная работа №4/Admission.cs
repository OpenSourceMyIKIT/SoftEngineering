namespace Лабораторная_работа__4
{
    // Класс, содержащий информацию о всех записях на прием
    class Admission
    {
        private string specialist;
        private string aim;
        private string time;        
        private string client;        

        // Конструктор класса записи на прием
        public Admission(string client, string specialist, string time, string aim)
        {
            this.client = client;
            this.specialist = specialist;
            this.time = time;
            this.aim = aim;
        }       

        public bool checkMatches(string specialist, string time)
        {           
            if (this.specialist == specialist && this.time == time)
                return true;
            else
                return false;
        }
    }
}
