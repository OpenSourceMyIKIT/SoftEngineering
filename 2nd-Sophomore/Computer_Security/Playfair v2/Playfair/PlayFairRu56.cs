namespace Playfair
{
    public class PlayFairRu56 : PlayFairSettings
    {
        public PlayFairRu56()
            : base()
        {
            Replaces.Add('ё', 'е');
            Replaces.Add('й', 'и');
            Replaces.Add('ъ', 'ь');
        }

        protected override char[] AlphabetChars
        {
            get { return "абвгдежзиклмнопрстуфхцчшщьыэюя".ToCharArray(); }
        }

        public override char Replacer
        {
            get { return 'х'; }
        }

        public override int Columns
        {
            get { return 5; }
        }

        public override int Rows
        {
            get { return 6; }
        }
    }
}
