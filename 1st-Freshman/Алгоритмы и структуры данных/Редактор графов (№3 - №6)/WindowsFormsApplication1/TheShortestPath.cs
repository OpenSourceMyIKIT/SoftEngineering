using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TheShortestPath : Form
    {
        public TheShortestPath()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form2 mainForm = this.Owner as Form2;
            try
            {
                mainForm.shortestPath1 = Convert.ToInt32(tbNumFirst.Text);
                mainForm.shortestPath2 = Convert.ToInt32(tbNumSecond.Text);                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
