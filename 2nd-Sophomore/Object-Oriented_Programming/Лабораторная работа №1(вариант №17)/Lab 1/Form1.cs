using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        #region Service
        public List<Sportsman> sportsmen = new List<Sportsman>();
        public List<Team> teams = new List<Team>();
        public List<Schedule> schedules = new List<Schedule>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvSchedule.Clear();
            lvSportsmen.Clear();
            cbTeamSelector.Items.Clear();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lvSchedule.Clear();
            lvSportsmen.Clear();
            cbTeamSelector.Items.Clear();
            for (int i = 0; i < teams.Count; ++i)
                cbTeamSelector.Items.Add(teams[i].Name);
            label1.Text = "Team";
            label2.Text = "Sportsmen";
            label3.Text = "Schedule";
            btnChange.Text = "View schedules";
        }
        #endregion

        #region Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addSportsmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSportsman addSportsman = new AddSportsman();
            addSportsman.Owner = this;
            addSportsman.Show();
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeam addTeam = new AddTeam();
            addTeam.Owner = this;
            addTeam.Show();
        }

        private void addScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.Owner = this;
            addSchedule.Show();
        }

        private void editTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTeam editTeam = new EditTeam();
            editTeam.Owner = this;
            editTeam.Show();
        }
        #endregion

        #region Changing items to view
        private void btnChange_Click(object sender, EventArgs e)
        {
            switch(btnChange.Text)
            {
                case "View schedules":
                    btnChange.Text = "View teams";
                    label1.Text = "Schedule";
                    label2.Text = "Sportsmen";
                    label3.Text = "Teams";
                    lvSchedule.Clear();
                    lvSportsmen.Clear();
                    cbTeamSelector.Items.Clear();
                    for (int i = 0; i < schedules.Count; ++i)
                        cbTeamSelector.Items.Add(schedules[i].Date);
                    break;

                case "View teams":
                    btnChange.Text = "View schedules";
                    label1.Text = "Team";
                    label2.Text = "Sportsmen";
                    label3.Text = "Schedule";
                    lvSchedule.Clear();
                    lvSportsmen.Clear();
                    cbTeamSelector.Items.Clear();
                    for (int i = 0; i < teams.Count; ++i)
                        cbTeamSelector.Items.Add(teams[i].Name);
                    break;
            }
        }
        #endregion

        #region Populating ListView
        private void cbTeamSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cbTeamSelector.SelectedIndex;
            lvSchedule.Clear();
            lvSportsmen.Clear();
            switch (btnChange.Text)
            {
                case "View schedules":
                    lvSportsmen.Columns.Add("Name");
                    lvSportsmen.Columns.Add("Surname");

                    for (int i = 0; i < teams[n].Sportsmen.Count; ++i)
                    {
                        lvSportsmen.Items.Add(new ListViewItem(
                                              new string[] { teams[n].Sportsmen[i].Name,
                                                             teams[n].Sportsmen[i].Surname }));
                    }

                    lvSchedule.Columns.Add("Date");

                    for (int i = 0; i < teams[n].Schedule.Count; ++i)
                    {
                        lvSchedule.Items.Add(new ListViewItem(
                                             new string[] { teams[n].Schedule[i].Date }));
                    }

                    break;

                case "View teams":
                    lvSchedule.Columns.Add("Name");
                    lvSchedule.Columns.Add("Score");

                    for (int i = 0; i < schedules[n].Teams.Count; ++i)
                    {
                        lvSchedule.Items.Add(new ListViewItem(
                                             new string[] { schedules[n].Teams[i].Name,
                                                            schedules[n].Teams[i].Score.ToString() }));
                    }

                    lvSportsmen.Columns.Add("Name");
                    lvSportsmen.Columns.Add("Surname");

                    for (int i = 0; i < schedules[n].Teams.Count; ++i)
                    {
                        for (int j = 0; j < schedules[n].Teams[i].Sportsmen.Count; ++j)
                        {
                            lvSportsmen.Items.Add(new ListViewItem(
                                                  new string[] { schedules[n].Teams[i].Sportsmen[j].Name,
                                                                 schedules[n].Teams[i].Sportsmen[j].Surname }));
                        }
                    }
                    break;
            }
        }
        #endregion
    }
}
