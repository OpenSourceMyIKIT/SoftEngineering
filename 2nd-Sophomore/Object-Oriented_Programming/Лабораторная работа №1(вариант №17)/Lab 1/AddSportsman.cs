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
    public partial class AddSportsman : Form
    {
        public AddSportsman()
        {
            InitializeComponent();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            Form1 frm = this.Owner as Form1;
            if (frm != null)
            {
                Sportsman tmpSportsman = new Sportsman(tbName.Text, tbSurname.Text, tbSport.Text);
                frm.sportsmen.Add(tmpSportsman);
            }
            this.Close();
        }
    }
}
