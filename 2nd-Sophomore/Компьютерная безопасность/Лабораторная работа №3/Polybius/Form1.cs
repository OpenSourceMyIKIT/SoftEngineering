using System;
using System.Threading;
using System.Windows.Forms;

namespace Polybius
{
    public partial class Form1 : Form
    {
        char[,] alpharus = {     
                            {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                            {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                            {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                            {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                            {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                            { '2','3', '4', '5', '6', '7', '8'},
                            {'9', ' ', ',', '.', '!', '?', ';'}
        };

        char[,] alphaeng = {
                            {'A', 'B', 'C', 'D', 'E', 'F'},
                            {'G', 'H', 'I', 'J', 'K', 'L'},
                            {'M', 'N', 'O', 'P', 'Q', 'R'},
                            {'S', 'T', 'U', 'V', 'W', 'X'},
                            {'Y', 'Z', '1', '2', '3', '4'},
                            {'5', '6', '7', '8', '9', ' '}
        };

        public Form1()
        {
            InitializeComponent();
            cbAlphabet.Items.Add("Русский");
            cbAlphabet.Items.Add("Английский");
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (cbAlphabet.SelectedIndex == 0)
            {
                Encode(alpharus);
            }
            if (cbAlphabet.SelectedIndex == 1)
            {
                Encode(alphaeng);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (cbAlphabet.SelectedIndex == 0)
            {
                Decode(alpharus);
            }
            if (cbAlphabet.SelectedIndex == 1)
            {
                Decode(alphaeng);
            }
        }

        private void btnPrison_Click(object sender, EventArgs e)
        {
            if (cbAlphabet.SelectedIndex == 0)
            {
                PrisonCode(alpharus);
            }
            if (cbAlphabet.SelectedIndex == 1)
            {
                PrisonCode(alphaeng);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Encode(char[,] alphabet)
        {
            string message = tbInputEncode.Text;
            string newMessage = "";

            for (int i = 0; i < message.Length; ++i)
            {
                for (int j = 0; j < alphabet.GetLength(0); ++j)
                    for (int k = 0; k < alphabet.GetLength(1); ++k)
                        if (Char.ToLower(alphabet[j, k]) == message[i] ||
                            Char.ToUpper(alphabet[j, k]) == message[i])
                        {
                            newMessage += (Convert.ToString(j) + Convert.ToString(k) + " ");
                            break;
                        }
            }
            tbResultEncode.Text = newMessage;
        }

        public void Decode(char[,] alphabet)
        {
            string message = tbInputDecode.Text;
            string newMessage = "";
            for (int a = 0; a < message.Length; a += 2)
            {
                newMessage += alphabet[Convert.ToInt32(message[a].ToString()), 
                    Convert.ToInt32(message[a + 1].ToString())];
            }
            tbResultDecode.Text = newMessage;
        }

        public void PrisonCode(char[,] alphabet)
        {
            string message = tbInputEncode.Text;

            for (int i = 0; i < message.Length; ++i)
            {
                for (int j = 0; j < alphabet.GetLength(0); ++j)
                    for (int k = 0; k < alphabet.GetLength(1); ++k)
                        if (Char.ToLower(alphabet[j, k]) == message[i] ||
                            Char.ToUpper(alphabet[j, k]) == message[i])
                        {
                            if (message[i].ToString() != " ")
                            {
                                for (int b1 = 0; b1 <= j; ++b1)
                                    Console.Beep(400, 800);

                                for (int b2 = 0; b2 <= k; ++b2)
                                    Console.Beep(800, 800);
                            }                           
                            Thread.Sleep(1000);
                        }
            }
        }

        private void tbInputEncode_Click(object sender, EventArgs e)
        {
            tbInputEncode.Text = "";
        }

        private void tbInputDecode_Click(object sender, EventArgs e)
        {
            tbInputDecode.Text = "";
        }
    }
}