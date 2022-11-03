using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aula13Foreach
    {
        public static void Aula13()
        {
            Console.WriteLine("FOREACH");
            string[] diasSemanas = new string[] { "DOM", "SEG", "TER", "QUA", "QUI", "SEX", "SAB" };

            foreach (string dia in diasSemanas)
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

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("======================================");
        }
    }
}
