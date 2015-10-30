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
    public partial class EditTeam : Form
    {
        #region Service
        public EditTeam()
        {
            InitializeComponent();
        }

        private void EditTeam_Load(object sender, EventArgs e)
        {
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                for (int i = 0; i < frm.teams.Count; ++i)
                    cbTeams.Items.Add(frm.teams[i].Name);
            }
        }

        private void ClearCBText()
        {
            cbScheduleDelete.Text = "";
            cbSchedulesAdd.Text = "";
            cbSportsmenAdd.Text = "";
            cbSportsmenDelete.Text = "";
        }
        #endregion

        #region Populating ComboBoxes
        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cbTeams.SelectedIndex;
            cbSportsmenAdd.Items.Clear();
            cbSchedulesAdd.Items.Clear();
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                refreshDeleteLists();

                for (int i = 0; i < frm.sportsmen.Count; ++i)
                    cbSportsmenAdd.Items.Add(frm.sportsmen[i].Info);

                for (int i = 0; i < frm.schedules.Count; ++i)
                    cbSchedulesAdd.Items.Add(frm.schedules[i].Date);
            }
            ClearCBText();
        }

        private void refreshDeleteLists()
        {
            int n = cbTeams.SelectedIndex;
            Form1 frm = this.Owner as Form1;
            cbSportsmenDelete.Items.Clear();
            cbScheduleDelete.Items.Clear();
            if (frm != null)
            {
                if (frm.teams[n].Sportsmen != null)
                    for (int i = 0; i < frm.teams[n].Sportsmen.Count; ++i)
                        cbSportsmenDelete.Items.Add(frm.teams[n].getSportsman(i));

                if (frm.teams[n].Schedule != null)
                    for (int i = 0; i < frm.teams[n].Schedule.Count; ++i)
                        cbScheduleDelete.Items.Add(frm.teams[n].getSchedule(i));
            }
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSportsman_Click(object sender, EventArgs e)
        {
            int n = cbTeams.SelectedIndex;
            int n1 = cbSportsmenAdd.SelectedIndex;
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                frm.teams[n].newSportsman(frm.sportsmen[n1]);
                frm.sportsmen[n1].AddTeam(frm.sportsmen[n1], frm.teams[n]);
            }
            refreshDeleteLists();
            ClearCBText();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            int n = cbTeams.SelectedIndex;
            int n1 = cbSchedulesAdd.SelectedIndex;
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                frm.teams[n].newSchedule(frm.schedules[n1]);
                frm.schedules[n1].addTeam(frm.schedules[n1], frm.teams[n]);
            }
            refreshDeleteLists();
            ClearCBText();
        }

        private void btnDeleteSportsman_Click(object sender, EventArgs e)
        {
            int n = cbTeams.SelectedIndex;
            int n1 = cbSportsmenDelete.SelectedIndex;
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                frm.teams[n].Sportsmen.RemoveAt(n1);
                for (int i = 0; i < frm.sportsmen.Count; ++i)
                {
                    if ((frm.sportsmen[i].Name == frm.teams[n].Sportsmen[n1].Name) &&
                         (frm.sportsmen[i].Surname == frm.teams[n].Sportsmen[n1].Surname))
                        frm.sportsmen.RemoveAt(i); break;
                }
            }
            refreshDeleteLists();
            ClearCBText();

        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            int n = cbTeams.SelectedIndex;
            int n1 = cbScheduleDelete.SelectedIndex;
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                frm.teams[n].Schedule.RemoveAt(n1);
                for (int i = 0; i < frm.schedules.Count; ++i)
                {
                    if ((frm.schedules[i].Day == frm.teams[n].Schedule[n1].Day) &&
                         (frm.schedules[i].Month == frm.teams[n].Schedule[n1].Month) &&
                          (frm.schedules[i].Year == frm.teams[n].Schedule[n1].Year))
                        frm.schedules.RemoveAt(i); break;
                }
            }
            refreshDeleteLists();
            ClearCBText();
        }
        #endregion
    }
}
