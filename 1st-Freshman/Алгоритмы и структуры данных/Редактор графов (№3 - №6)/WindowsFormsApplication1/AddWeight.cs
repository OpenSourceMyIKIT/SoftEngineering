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
    public partial class AddWeight : Form
    {
        public AddWeight()
        {
            InitializeComponent();
        }

        private void tbAddWeight_Click(object sender, EventArgs e)
        {
            tbAddWeight.Clear();
        }

        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            Form2 mainForm = this.Owner as Form2; // Главная форма родитель данной
            try
            {
                int currWeight = Convert.ToInt32(tbAddWeight.Text);
                if (currWeight < 0)
                    MessageBox.Show("Введите неотрицательное значение");
                else
                {
                    mainForm.currWeight = currWeight;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
