namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Seja Bem Vindo ao Sistema!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Bhaskara");
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("----------------------------");
            Console.Write("Selecione uma opção: ");
            short opt = short.Parse(Console.ReadLine());

            switch(opt)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicao(); break;
                case 5: Bhaskara(); break;
                case 6: Porcentagem(); break;
                case 7: Sair(); break;
                default: Menu(); break;
            }
        }

        #region Soma
        private static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Cálculo de Soma\n");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}\n");

            RetornaMenu();
        }
        #endregion

        #region Subtração
        private static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Cálculo de Subtração\n");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}\n");

            RetornaMenu();
        }
        #endregion

        #region Divisão
        private static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Cálculo de Divisão\n");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisao é {resultado}\n");

            RetornaMenu();
        }
        #endregion

        #region Multiplicação
        private static void Multiplicao()
        {
            Console.Clear();

            Console.WriteLine("Cálculo de Multiplicação\n");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicaçao é {resultado}\n");

            RetornaMenu();
        }
        #endregion

        #region Bhaskara
        private static void Bhaskara()
        {
            Console.Clear();

            Console.WriteLine("Cálculo de Bhaskara\n");

            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2.0) - (4 * a * c);
            Console.WriteLine($"\nDelta = {delta}\n");

            if ((delta < 0) || (a == 0))
            {
                Console.WriteLine("Impossível Calcular\n");
            }
            else
            {
                double x1 = (-b + Math.Pow(delta, 2)) / (2 * a);
                double x2 = (-b - Math.Pow(delta, 2)) / (2 * a);

                Console.WriteLine($"Resultado X1 = {x1}\n");
                Console.WriteLine($"Resultado X2 = {x2}\n");
            }

            RetornaMenu();
        }
        #endregion

        #region Porcentagem
        private static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Cálculo de Porcentagem\n");

            Console.Write("Digite o valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem: ");
            decimal porcentagem = decimal.Parse(Console.ReadLine());

            decimal resultado = (porcentagem / 100) * valor;
            Console.WriteLine($"{porcentagem}% de {valor} = {decimal.Floor(resultado)}");

            RetornaMenu();
        }
        #endregion

        private static void Sair()
        {
            Console.Clear();

            Console.WriteLine("Obrigado por utilizar nosso Sistema! :)");

            Environment.Exit(0);
        }

        private static void RetornaMenu()
        {
            Console.Write("Pressione qualquer tecla para retornar ao menu...");
            Console.ReadKey();
            Menu();
        }
    }
}