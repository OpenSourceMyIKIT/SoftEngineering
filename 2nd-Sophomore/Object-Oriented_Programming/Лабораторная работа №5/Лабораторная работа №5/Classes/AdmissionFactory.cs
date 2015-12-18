using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__5
{
    class AdmissionFactory : AbstractFactory
    {
        private string specialist;
        private string time;
        private string client;
        private string aim;

        public Admission CreateAdmission()
        {
            Admission a = new Admission();
            a.SetSpecialist(specialist);
            a.SetTime(time);
            a.SetClient(client);
            if (aim != "")
                a.SetAim(aim);
            return a;
        }

        public void SetSpecialist(string value)
        {
            specialist = value;
        }

        public void SetTime(string value)
        {
            time = value;
        }

        public void SetClient(string value)
        {
            client = value;
        }

        public void SetAim(string value)
        {
            aim = value;
        }
    }
}
