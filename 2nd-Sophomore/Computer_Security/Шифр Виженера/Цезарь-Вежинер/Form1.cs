using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Цезарь_Вежинер
{
    public partial class Form1 : Form
    {
        string alphabet = "абвгдежзийклмнопрстуфхцчшщьыъэюя ";

        public Form1()
        {
            InitializeComponent();
        }

        private void code_Click(object sender, EventArgs e)
        {

            input.Text = input.Text.ToLower();
            key.Text = keyOl.Text.ToLower();
            key.Text = output.Text = "";

            for (int i = 0; i < keyOl.Text.Length; i++)
            {
                int x = alphabet.IndexOf(keyOl.Text[i]);

                if (x < alphabet.Length - 1)
                    key.Text += alphabet[x];
                else
                    key.Text += alphabet[x + 1 - alphabet.Length];
            }

            for (int i = 0, j = 0; i < input.Text.Length; i++, j++)
            {
                if (j >= key.Text.Length) j = 0;

                int x = alphabet.IndexOf(input.Text[i]);
                int y = alphabet.IndexOf(key.Text[j]);

                if (x + y < alphabet.Length - 1)
                    output.Text += alphabet[x + y];
                else
                    output.Text += alphabet[x + y + 1 - alphabet.Length];
            }
        }
        
        private void decode_Click(object sender, EventArgs e)
        {
            output.Text = "";
            for (int i = 0, j = 0; i < input.Text.Length; i++, j++)
            {
                if (j >= key.Text.Length) j = 0;

                int x = alphabet.IndexOf(input.Text[i]);
                int y = alphabet.IndexOf(key.Text[j]);

                if (x - y >= 0)
                    output.Text += alphabet[x - y];
                else
                    output.Text += alphabet[x - y - 1 + alphabet.Length];
            }
        }
    }
}
