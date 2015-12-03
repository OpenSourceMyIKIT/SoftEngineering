using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кардано
{
    public partial class Form1 : Form
    {
        int del = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void code_Click(object sender, EventArgs e)
        {
            output.Text = "";
            keyLb.Text = "";
            int por = 2;
            int count = input.Text.Length / 4 + (input.Text.Length % 4 == 0 ? 0 : 1);
            del = count * 4 - input.Text.Length;
            int ind = 0;

            Random r = new Random();
            List<int> key = new List<int>();

            if (input.Text.Length / 4 < Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32(comboBox1.SelectedItem))
                por = Convert.ToInt32(comboBox1.SelectedItem);
            else return;

            for (int i = 0; i < por * por; i++)
                key.Add(i < count ? 1 : 0);
            key = key.OrderBy(i => r.Next()).ToList();

            for (int i = key.Count - 1; i > 0; i--)
            {
                int index = r.Next(i + 1);
                int a = key[index];
                key[index] = key[i];
                key[i] = a;
            }

            for (int i = 0; i < key.Count; i++)
                keyLb.Text += key[i];

            dataGrid.ColumnCount = dataGrid.RowCount = por * 2;

            for (int i = 0; i < por; i++)
                for (int j = 0; j < por; j++)
                    dataGrid.Rows[i].Cells[j].Value = key[ind++];

            for (int i = 0; i < por; i++)
                for (int j = por; j < por * 2; j++)
                    dataGrid.Rows[i].Cells[j].Value = dataGrid.Rows[i].Cells[j - 1 - (2 * (j - por))].Value;

            for (int i = por; i < por * 2; i++)
                for (int j = 0; j < por; j++)
                    dataGrid.Rows[i].Cells[j].Value = dataGrid.Rows[i - 1 - (2 * (i - por))].Cells[j].Value;

            for (int i = por; i < por * 2; i++)
                for (int j = por; j < por * 2; j++)
                    dataGrid.Rows[i].Cells[j].Value = dataGrid.Rows[i - 1 - (2 * (i - por))].Cells[j - 1 - (2 * (j - por))].Value;

            ind = 0;

            for (int i = 0; i < por * 2; i++)
                for (int j = 0; j < por * 2; j++)
                    if (dataGrid.Rows[i].Cells[j].Value.ToString() == "1" && ind < input.Text.Length)
                        dataGrid.Rows[i].Cells[j].Value = input.Text[ind++];
                    else
                        dataGrid.Rows[i].Cells[j].Value = Convert.ToChar(r.Next(0, 255));

            for (int i = 0; i < por * 2; i++)
                for (int j = 0; j < por * 2; j++)
                    output.Text += dataGrid.Rows[i].Cells[j].Value;
        }

        private void uncode_Click(object sender, EventArgs e)
        {
            int por = dataGrid.ColumnCount / 2;
            List<string> key = new List<string>();
            int ind = 0;
            string str = "";
            output.Text = "";

            for (int i = 0; i < keyLb.Text.Length; i++)
                key.Add(keyLb.Text[i].ToString());

            int[,] ch = new int[por * 2, por * 2];

            for (int i = 0; i < por; i++)
                for (int j = 0; j < por; j++)
                    ch[i, j] = Convert.ToInt32(key[ind++]);

            for (int i = 0; i < por; i++)
                for (int j = por; j < por * 2; j++)
                    ch[i, j] = ch[i, j - 1 - (2 * (j - por))];

            for (int i = por; i < por * 2; i++)
                for (int j = 0; j < por; j++)
                    ch[i, j] = ch[i - 1 - (2 * (i - por)), j];

            for (int i = por; i < por * 2; i++)
                for (int j = por; j < por * 2; j++)
                    ch[i, j] = ch[i - 1 - (2 * (i - por)), j - 1 - (2 * (j - por))];

            for (int i = 0; i < por * 2; i++)
                for (int j = 0; j < por * 2; j++)
                    if (ch[i, j] == 1)
                        str += dataGrid.Rows[i].Cells[j].Value;

            for (int i = 0; i < str.Length - del; i++)
                output.Text += str[i];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Size: " + comboBox1.SelectedItem;

        }
    }
}
 