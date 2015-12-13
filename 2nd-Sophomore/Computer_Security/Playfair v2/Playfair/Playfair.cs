using System;
using System.Collections.Generic;
using System.Text;

namespace Playfair
{
    public sealed class PlayFair
    {
        private struct TablePosition
        {
            public int Row;
            public int Column;

            public TablePosition(int Row, int Column)
            {
                this.Row = Row;
                this.Column = Column;
            }
        }

        private char[,] Matrix;
        private Dictionary<char, TablePosition> Positions; // Позиции символов в матрице

        public PlayFairSettings Settings { get; private set; }
        public string Key { get; private set; }

        public PlayFair(PlayFairSettings Settings, string Key)
        {
            this.Settings = Settings;
            this.Key = Key;

            // Формирование матрицы
            Positions = new Dictionary<char, TablePosition>();
            var items = MatrixItems().GetEnumerator();
            Matrix = new char[Settings.Rows, Settings.Columns];
            for (var r = 0; r < Settings.Rows; r++)
            {
                for (var c = 0; c < Settings.Columns; c++)
                {
                    if (items.MoveNext())
                    {
                        Matrix[r, c] = items.Current;
                        Positions.Add(items.Current, new TablePosition(r, c));
                    }
                    else throw new ArgumentException("Алфавит слишком маленький");
                }
            }
        }

        /// <summary> Перечисление элементов матрицы </summary>
        private IEnumerable<char> MatrixItems()
        {
            var used = new HashSet<char>();

            // Сначала пишем символы ключа
            foreach (var c in Key)
            {
                var rc = Settings.GetChar(c);
                if (used.Contains(rc)) continue;
                used.Add(rc);
                yield return rc;
            }

            // Теперь оставшиеся символы алфавита
            foreach (var c in Settings.Alphabet)
            {
                if (used.Contains(c)) continue;
                used.Add(c);
                yield return c;
            }
        }

        /// <summary>
        ///     Разбиение текста на символы по биграммам.
        ///     Replacer выкидывается
        /// </summary>
        private IEnumerable<char> Bigrams(string Text)
        {
            var prev = '\0'; // Храним первый символ биграммы
            var even = false; // если второй символ биграммы
            foreach (var c in Text)
            {
                // Преобразуем символ из текста
                // он может стать Replacer'ом, если, например, это пробел
                var rc = Settings.GetChar(c);

                if (!even) // Если это первый символ биграммы
                {
                    // запоминаем и ищем второй
                    prev = rc;
                    even = true;
                }
                else
                {
                    // Это второй символ биграммы
                    if (prev == rc) // и он такойже как и первый
                    {
                        if (prev != Settings.Replacer) // а первый не Replacer
                        {
                            // то вернем биграмму с Replacer в конце
                            yield return prev;
                            yield return Settings.Replacer;

                            // и будем считать, что уже нашли первый символ в следующей биграмме
                            prev = rc;
                        }
                    }
                    else
                    {
                        // Ну, а если они разные, то вернем оба и будем искать дальше
                        yield return prev;
                        yield return rc;
                        even = false;
                    }
                }
            }

            // Если мы ищем второй символ, а строка закончилась, 
            // при этом первый символ не Replacer
            if (even && prev != Settings.Replacer)
            {
                yield return prev;
                yield return Settings.Replacer;
            }
        }

        /// <summary>
        /// Шифр Плейфера
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <param name="modeCrypt">True если нужно зашифровать. False - расшифровать</param>
        public string Crypt(string text, bool modeCrypt = true)
        {
            var shift = modeCrypt ? 1 : -1;
            var sb = new StringBuilder();
            // Разбиваем на биграммы
            var chars = Bigrams(text).GetEnumerator();
            while (chars.MoveNext())
            {
                // Получаем координаты символов биграммы в таблице
                // При расшифровке, если шифротекст неверен 
                // т.е. имеет нечетную длину или неизвестные алфавиту символы
                // вылетит исключение (поэтому лучше раздить на два метода: шифровки и дешифровки
                // и перебрасывать исключение). Для шифровки такого не будет
                var p1 = Positions[chars.Current];
                chars.MoveNext();
                var p2 = Positions[chars.Current];

                // Если они на одной строке - переводим вправо
                // Если в одной колнке - вниз
                var error = 0;
                if (p1.Column == p2.Column)
                {
                    p1.Column = Mod(p1.Column + shift, Settings.Columns);
                    p2.Column = Mod(p2.Column + shift, Settings.Columns);
                    error++;
                }
                else if (p1.Row == p2.Row)
                {
                    p1.Row = Mod(p1.Row + shift, Settings.Rows);
                    p2.Row = Mod(p2.Row + shift, Settings.Rows);
                    error++;
                }

                if (error == 2)
                    throw new ArgumentException("Неверные биграммы");

                sb.Append(Matrix[p1.Row, p2.Column]);
                sb.Append(Matrix[p2.Row, p1.Column]);
            }
            return sb.ToString();
        }

        private static int Mod(int x, int m)
        {
            // остаток от деления для отрицательных чисел
            // для -1 вернет (m-1)
            return (x%m + m)%m;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Ключ: ");
            sb.AppendLine(Key);
            for (var r = 0; r < Settings.Rows; r++)
            {
                for (var c = 0; c < Settings.Columns; c++)
                {
                    sb.Append(Matrix[r, c]);
                    sb.Append(' ');
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
