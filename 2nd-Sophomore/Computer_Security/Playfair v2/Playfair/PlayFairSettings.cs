using System.Collections.Generic;

namespace Playfair
{
    public abstract class PlayFairSettings
    {
        protected HashSet<char> HsAlphabet { get; private set; }
        protected Dictionary<char, char> Replaces { get; private set; }

        protected abstract char[] AlphabetChars { get; }

        /// <summary>Число столбцов в матрице</summary>
        public abstract int Columns { get; }

        /// <summary>Число строк в матрице</summary>
        public abstract int Rows { get; }

        /// <summary>Символ-заменитель</summary>
        public abstract char Replacer { get; }

        /// <summary>Алфавит</summary>
        public IEnumerable<char> Alphabet
        {
            get
            {
                var chars = AlphabetChars;
                foreach (var c in chars)
                    yield return c;
            }
        }

        public PlayFairSettings()
        {
            HsAlphabet = new HashSet<char>();
            Replaces = new Dictionary<char, char>();

            // Переносим символы алфавита в хэштаблицу, чтобы 
            // убрать повторяющиеся значения и быстро определять
            // принадлежит символ алфавиту или нет
            foreach (var c in AlphabetChars)
                HsAlphabet.Add(c);
        }

        /// <summary>Возвращает символ после всех преобразований</summary>
        /// <remarks>Если символ не принадлежит алфавиту, будет поставлен Replacer.</remarks>
        public char GetChar(char Char)
        {
            Char = char.ToLower(Char);
            Char = Replaces.ContainsKey(Char) ? Replaces[Char] : Char;
            return HsAlphabet.Contains(Char) ? Char : Replacer;
        }
    }
}
