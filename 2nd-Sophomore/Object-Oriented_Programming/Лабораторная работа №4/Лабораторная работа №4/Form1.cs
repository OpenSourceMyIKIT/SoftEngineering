using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Лабораторная_работа__4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Инициализация базы данных клиентов
            Controller.initClientDB();
            List<string> s = Controller.getStringClients();
            for (int i = 0; i < s.Count; ++i)
            {
                cbClientDB.Items.Add(s[i]);
            }
        }

        private void cbClientDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSpecialist.Enabled = true;
            tbTime.Enabled = true;
            tbAim.Enabled = true;
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            if (Controller.addAdmission(cbClientDB.SelectedItem.ToString(), tbSpecialist.Text, tbTime.Text, tbAim.Text))
            {
                tbSpecialist.Text = "";
                tbTime.Text = "";
                tbAim.Text = "";
                MessageBox.Show("Новая запись успешно добавлена!");
            }
            else
                MessageBox.Show("В указанное время специалист уже ведет прием");
        }
    }
}