using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Schedule
    {
        private int day;
        private int month;
        private int year;

        private List<Team> teams = new List<Team>();

        #region Properties
        public int Day
        {
            set
            {
                if ((value > 0) && (value < 32))
                    day = value;
            }
            get
            {
                return day;
            }
        }

        public int Month
        {
            set
            {
                if ((value > 0) && (value < 13))
                    month = value;
            }
            get
            {
                return month;
            }
        }

        public int Year
        {
            set
            {
                if ((value > 1900) && (value < 2050))
                    year = value;
            }
            get
            {
                return year;
            }
        }

        public string Date
        {
            get
            {
                string date = day + "." + month + "." + year;
                return date;
            }
        }

        public List<Team> Teams
        {
            get
            {
                return teams;
            }
        }
        #endregion

        #region Methods and Constructors
        public void addTeam (Schedule schedule, Team team)
        {
            schedule.teams.Add(team);
        }

        public Schedule(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Schedule(int day, int month, int year, Team team)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.teams.Add(team);
        }
        #endregion
    }
}
