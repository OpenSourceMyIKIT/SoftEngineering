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
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                Team tmpTeam = new Team(tbName.Text, Convert.ToInt32(tbScore.Text));
                frm.teams.Add(tmpTeam);
            }
            this.Close();
        }
    }
}
