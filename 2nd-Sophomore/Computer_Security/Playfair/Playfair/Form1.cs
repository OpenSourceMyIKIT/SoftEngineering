using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Form1 : Form
    {
        // Матрица которая используется для заполнения ключом,
        // а затем разбивается в двумерную матрицу
        private char[] _initialMatrix = new char[25];
        private char[,] _keyMatrix = new char[5,5];

        // Ключ, который задает пользователь
        private string _key;
        private char[] _alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                                     'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                     'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            FillInitialMatrix();
            FillAlphabetMatrix();
            FillKeyMatrix();
        }

        // Заполняет начальную матрицу ключом (без повторений)
        private void FillInitialMatrix()
        {
            _key = tbKey.Text;
            int j = 0;
            for (int i = 0; i < _key.Length; ++i)
            {
                if (!(CheckMatches(i, _key[i])))
                {
                    _initialMatrix[j] = _key[i];
                    j++;
                }
            }
        }

        // Проверяет совпадение заносимого символа со всеми уже записанными символами
        private bool CheckMatches(int index, char c)
        {
            for (var i = 0; i < index; ++i)
            {              
               if (c == _initialMatrix[i]) return true;              
            }
            return false;
        }

        // Добавляет к начальной матрице алфавит (без повторений)
        private void FillAlphabetMatrix()
        {
            int j = 0;
            for (int i = 0; i < _alphabet.Length; ++i)
            {
                if (_initialMatrix[i] == '\0')
                { 
                    if (!(CheckMatches(i, _alphabet[j])))
                    {
                        _initialMatrix[i] = _alphabet[j];
                        j++;
                        continue;
                    }                    
                    j++;
                    i--;
                }
            }
        }

        // Разбивает одномерную матрицу на двумерную
        private void FillKeyMatrix()
        {
            int k = 0;
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    _keyMatrix[i, j] = _initialMatrix[k];
                    ++k;
                }
        }
    }
}
