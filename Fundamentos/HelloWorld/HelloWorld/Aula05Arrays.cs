using static System.Console;

namespace HelloWorld
{
    internal class Aula05Arrays
    {
        static void Aula05()
        {
            int[] x = new int[3];
            x[0] = 5;
            x[1] = 10;
            x[2] = 15;
            WriteLine(x[1]);

            string[] nomes = new string[2];
            nomes[0] = "Fabrício";
            nomes[1] = "Patinhas";
            WriteLine(nomes[0]);
            WriteLine(nomes[1]);

            string[] diasSemanas = new string[] { "DOM", "SEG", "TER", "QUA", "QUI", "SEX", "SAB" };
            WriteLine(diasSemanas[4]);
        }
    }
}
