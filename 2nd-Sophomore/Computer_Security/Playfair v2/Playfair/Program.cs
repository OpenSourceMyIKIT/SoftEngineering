using System;
using System.Windows.Forms;

namespace Playfair
{
    internal class Program
    {
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //try
            //{
            //    PlayFairSettings ps = new PlayFairRu56();
            //    var pf = new PlayFair(ps, "Шифр Плейфера");
            //    Console.WriteLine(pf);

            //    var text = "Текст который нужно зашифровать шифром Плейферах";
            //    Console.WriteLine("Исходный текст\r\n" + text);

            //    var i = 0;
            //    foreach (var c in pf.Bigrams(text))
            //    {
            //        Console.Write(c);

            //        i++;
            //        if (i%2 == 0) Console.Write(' ');
            //        if (i%10 == 0) Console.WriteLine();
            //    }

            //    text = pf.Crypt(text, true);
            //    Console.WriteLine("\r\nЗашифрованный текст\r\n" + text);

            //    text = pf.Crypt(text, false);
            //    Console.WriteLine("\r\nРасшифрованный текст\r\n" + text);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();
        }
    }
}