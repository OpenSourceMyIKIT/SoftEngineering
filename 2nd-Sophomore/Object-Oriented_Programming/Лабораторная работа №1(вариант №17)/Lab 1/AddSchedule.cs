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
    public partial class AddSchedule : Form
    {
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                Schedule tmpSchedule = new Schedule(Convert.ToInt32(tbDay.Text), 
                                                    Convert.ToInt32(tbMonth.Text), 
                                                    Convert.ToInt32(tbYear.Text));
                frm.schedules.Add(tmpSchedule);
            }
            this.Close();
        }
    }
}
