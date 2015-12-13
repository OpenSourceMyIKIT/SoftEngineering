using System;
using System.Windows.Forms;

namespace Playfair
{
    public partial class Form1 : Form
    {
        /// Матрица которая используется для заполнения ключом,
        /// а затем разбивается в двумерную матрицу
        private char[] _initialMatrix = new char[25];
        private char[,] _keyMatrix = new char[5, 5];

        /// Ключ, который задает пользователь
        private string _key;

        private readonly char[] _alphabet =
        {
            'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'k',
            'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z'
        };

        private string _input;
        private string _output;

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

        /// Заполняет начальную матрицу ключом (без повторений)
        private void FillInitialMatrix()
        {
            _key = tbKey.Text;
            var j = 0;
            for (var i = 0; i < _key.Length; ++i)
            {
                if (CheckMatches(i, _key[i])) continue;
                _initialMatrix[j] = _key[i];
                j++;
            }
        }

        /// Проверяет совпадение заносимого символа со всеми уже записанными символами
        private bool CheckMatches(int index, char c)
        {
            for (var i = 0; i < index; ++i)
            {
                if (c == _initialMatrix[i]) return true;
            }
            return false;
        }

        /// Добавляет к начальной матрице алфавит (без повторений)
        private void FillAlphabetMatrix()
        {
            var j = 0;
            for (var i = 0; i < _alphabet.Length; ++i)
            {
                if (_initialMatrix[i] != '\0') continue;
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

        /// Разбивает одномерную матрицу на двумерную
        private void FillKeyMatrix()
        {
            var k = 0;
            for (var i = 0; i < 5; ++i)
                for (var j = 0; j < 5; ++j)
                {
                    _keyMatrix[i, j] = _initialMatrix[k];
                    ++k;
                }
        }


    }
}
