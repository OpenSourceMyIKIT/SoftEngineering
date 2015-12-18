using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__5
{
    // Класс, содержащий информацию о всех записях на прием
    class Admission
    {
        // Обязательные поля
        private string _specialist;
        private string _time;
        
        // Дополнительные поля
        private string _aim;               
        private string _client;        

        public string GetSpecialist()
        {
            return _specialist;
        }

        public void SetSpecialist(string value)
        {
            _specialist = value;
        }

        public string GetTime()
        {
            return _time;
        }

        public void SetTime(string value)
        {
            _time = value;
        }

        public string GetAim()
        {
            return _aim;
        }

        public void SetAim(string value)
        {
            _aim = value;
        }

        public string GetClient()
        {
            return _client;
        }

        public void SetClient(string value)
        {
            _client = value;
        }      

        public bool checkMatches(string specialist, string time)
        {           
            if (_specialist == specialist && _time == time)
                return true;
            else
                return false;
        }
    }
}
