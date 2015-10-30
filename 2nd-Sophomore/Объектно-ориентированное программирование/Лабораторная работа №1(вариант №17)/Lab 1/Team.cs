using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Team
    {
        private string name;
        private int score;

        private List<Sportsman> sportsmen = new List<Sportsman>();
        private List<Schedule> schedule = new List<Schedule>();

        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToString();
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public List<Sportsman> Sportsmen
        {
            get
            {
                return sportsmen;
            }
        }

        public List<Schedule> Schedule
        {
            get
            {
                return schedule;
            }
        }
        #endregion

        #region Methods and Constructors
        public string getSportsman(int n)
        {
            return sportsmen[n].Info;
        }

        public string getSchedule(int n)
        {
            return schedule[n].Date;
        }


        public void newSportsman(Sportsman man)
        {
            sportsmen.Add(man);
        }

        public void newSchedule(Schedule sch)
        {
            schedule.Add(sch);
        }

        public Team(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        #endregion
    }
}
