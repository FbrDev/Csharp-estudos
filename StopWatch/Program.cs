using System;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao StopWatch!");
            Console.WriteLine("S = Segundos => 10s = 10 Segundos");
            Console.WriteLine("M = Minutos => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string opcao = Console.ReadLine().ToLower();
            char type = Char.Parse(opcao.Substring(opcao.Length - 1, 1));
            int time = Int16.Parse(opcao.Substring(0, opcao.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                Environment.Exit(0);

            Opcao(time * multiplier);
        }

        static void Opcao(int time)
        {
            Console.Clear();
            Console.WriteLine("Como deseja que o cronômetro conte?");
            Console.WriteLine("R = Regressivo");
            Console.WriteLine("N = Normal");
            Console.WriteLine("1 = Retornar para o menu");
            Console.WriteLine("0 = Sair");

            char opcao = char.Parse(Console.ReadLine().ToLower());

            if (opcao == '1')
                Menu();

            if (opcao == '0')
                System.Environment.Exit(0);

            PreStart(time, opcao);
        }

        static void PreStart(int time, char opcao)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time, opcao);
        }

        static void Start(int time, char opcao)
        {
            if (opcao == 'n')
            {
                int currentTime = 0;

                while (currentTime != time)
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }

                Console.Clear();
                Finalizado();
            }
            else
            {
                int currentTime = 0;

                while (time >= currentTime)
                {
                    Console.Clear();
                    Console.WriteLine(time);
                    time--;
                    Thread.Sleep(1000);
                }

                Console.Clear();
                Finalizado();
            }
        }

        static void Finalizado()
        {
            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}