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
        private char[,] _keyMatrix = new char[5,5];
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
            FillKeyMatrix();
            FillAlphabetMatrix();
        }

        private void FillKeyMatrix()
        {
            var line = false;
            _key = tbKey.Text;
            var k = 0;
            var j = 0;

            for (var i = 0; i < 5; ++i)
            {
                if (line)
                {
                    j = 4;
                }
                else j = 0;

                if (k == _key.Length) break;
                for (; j < 5; ++j)
                {
                    if (k == _key.Length) break;
                    if (CheckMatches(i, _key[k]))
                    {
                        ++k;
                        if (j == 0)
                        {
                            --i;
                            line = true;
                            break;
                        }
                        --j;
                        continue;
                    }
                    if (line)
                    {
                        _keyMatrix[i, 0] = _key[k];
                        line = false;
                        ++k;
                        continue;
                    }
                    _keyMatrix[i, j] = _key[k];
                    ++k;
                }
            }
        }

        private bool CheckMatches(int x, char c)
        {
            for (var i = 0; i <= x; ++i)
            {
                for (var j = 0; j < 5; ++j)
                {
                    if (c == _keyMatrix[i, j]) return true;
                }
            }
            return false;
        }

        private void FillAlphabetMatrix()
        {
            var k = 0;
            var line = false;
            var j = 0;

            for (var i = 0; i < 5; ++i)
            {
                if (line)
                {
                    j = 4;
                }
                else j = 0;

                for (; j < 5; ++j)
                {
                    if (_keyMatrix[i, j] != '\0') continue;
                    if (CheckMatches(i, _alphabet[k]))
                    {
                        ++k;
                        if (j == 0)
                        {
                            --i;
                            line = true;
                            break;
                        }
                        --j;
                        continue;
                    }
                    _keyMatrix[i, j] = _alphabet[k];
                    ++k;
                }
            }
        }
    }
}
