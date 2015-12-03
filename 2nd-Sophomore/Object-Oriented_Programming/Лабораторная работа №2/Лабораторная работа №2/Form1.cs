using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    public partial class Form1 : Form
    {     
        
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            State.InitSpisok();
            State UK = new Monarchy("UK", "02.10.1000", "Elizabeth", true);
            State.AddState(UK);

            State USA = new Republic("USA", "15.04.1450","House Of Commons");
            State.AddState(USA);

            State Monaco = new Kingdom("Monaco", "24.06.1687", "Paolo The Great");
            State.AddState(Monaco);

            State China = new Republic("China", "08.01.630","Центральный военный совет");
            State.AddState(China);
        }

        private void cbStateList_Click(object sender, EventArgs e)
        {
            cbStateList.Items.Clear();
            for (int i = 0; i< State.Length(); i++)
            {
                cbStateList.Items.Add((State.GetState(i)).Info());
            }
            
        }

        private void clearFields()
        {
            tbName.Text = "";
            tbFoundation.Text = "";
            tbType.Text = "";
            tbGovernment.Text = "";
            tbSourceOfLaw.Text = "";
            tbMonarch.Text = "";            
            tbPowerInhereted.Text = "";
        }

        private void cbStateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStateList.Items.Count > 0 && cbStateList.SelectedItem != null) // Если выбран какой-либо элемент в comboBox
            {
                int index = cbStateList.SelectedIndex;               

                clearFields();
                tbName.Text = State.GetState(index).Info("name");
                tbFoundation.Text = State.GetState(index).Info("foundation");
                tbGovernment.Text = State.GetState(index).Info("government");
                tbSourceOfLaw.Text = State.GetState(index).Info("sourceoflaw");
                tbMonarch.Text = State.GetState(index).Info("monarch");
                tbPowerInhereted.Text = State.GetState(index).Info("powerinhereted");
            }
            else
                MessageBox.Show("Список государств пуст");
        }
    }
}
