using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Sportsman
    {
        private string name;
        private string surname;
        private string sport;

        private Team team;

        #region Properties
        public string Info
        {
            get
            {
                string info = surname + " " + name + ", " + sport;
                return info;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Sport
        {
            get
            {
                return sport;
            }
            set
            {
                sport = value;
            }
        }

        public Team Team
        {
            get
            {
                return team;
            }
        }
        #endregion

        #region Methods and Constructors
        public void AddTeam(Sportsman man, Team tm)
        {
            man.team = tm;
        }

        public Sportsman(string name, string surname, string sport, Team team)
        {
            this.name = name;
            this.surname = surname;
            this.sport = sport;
            this.team = team;
        }

        public Sportsman(string name, string surname, string sport)
        {
            this.name = name;
            this.surname = surname;
            this.sport = sport;
        }
        #endregion
    }
}