using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen("*", "=");
            WriteOptions();

            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(string symbol = "+", string symbol2 = "-", string symbolLines = "|", int columns = 30, int totalLines = 10)
        {
            DrawLine(symbol, symbol2, columns);
            for (int lines = 0; lines <= totalLines; lines++)
            {
                Console.Write(symbolLines);

                for (int i = 0; i <= columns; i++)
                    Console.Write(" ");

                Console.Write(symbolLines);
                Console.Write("\n");
            }
            DrawLine(symbol, symbol2, columns);
        }

        private static void DrawLine(string symbol, string symbol2, int columns)
        {
            Console.Write(symbol);

            for (int i = 0; i <= columns; i++)
                Console.Write(symbol2);

            Console.Write(symbol);
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("        Editor HTML        ");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção:");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.AbrirArquivo(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}