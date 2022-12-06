using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public static class Viewer
    {
        public static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (StreamReader file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Viewer.Show(text);
            }
        }

        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo de Visualização");
            Console.WriteLine("====================");
            Replace(text);
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            Regex strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}