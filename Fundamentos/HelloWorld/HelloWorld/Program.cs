using System.Collections;
using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
        {
            string[] diasSemanas = new string[] { "DOM", "SEG", "TER", "QUA", "QUI", "SEX", "SAB" };

            foreach(string dia in diasSemanas)
            {
                Console.WriteLine(dia);
            }

            Queue fila = new Queue();
            fila.Enqueue("Fabrício");
            fila.Enqueue("Beatriz");
            fila.Enqueue("Patinhas");
            fila.Enqueue("Musk");

            foreach (string nome in fila)
            {
                Console.WriteLine(nome);
            }

            List<string> nomes = new List<string>();
            nomes.Add("Fernando");
            nomes.Add("Gilson");
            nomes.Add("Helio");

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}