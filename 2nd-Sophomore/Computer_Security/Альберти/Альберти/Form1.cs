using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Альберти
{
    public partial class Form1 : Form
    {
        private const string Alphabet = " АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
        private string Keyword;

        private char[,] CreateTable()
        {
            var result = new char[Alphabet.Length, Alphabet.Length];
            for (int i = 0; i < Alphabet.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    // Заполнение двумерной матрицы алфавитом со смещением
                    result[i, j] = Alphabet[(j - i + Alphabet.Length) % Alphabet.Length];
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void codeBtn_Click(object sender, EventArgs e)
        {
            Keyword = key.Text.ToLower();
            string s = input.Text.ToLower();
            var result = new StringBuilder(s.Length, s.Length);
            var table = CreateTable();
            for (int i = 0; i < s.Length; i++)
            {
                int j = s[i] == ' ' ? 32 : s[i] - 'а';
                int k = Keyword[i % Keyword.Length] - 'а';
                result.Append(table[k, j]);
            }
            output.Text = result.ToString();
        }

        private void uncodeBtn_Click(object sender, EventArgs e)
        {
            Keyword = key.Text.ToLower();
            string s = input.Text.ToUpper();
            var result = new StringBuilder(s.Length, s.Length);
            var table = CreateTable();
            for (int i = 0; i < s.Length; i++)
            {
                int k = Keyword[i % Keyword.Length] - 'а';
                int j = 0;
                for (; table[k, j] != s[i]; j++) { }
                result.Append((char)(j == 32 ? j : 'а' + j));
            }
            output.Text = result.ToString();
        }
    }
}
