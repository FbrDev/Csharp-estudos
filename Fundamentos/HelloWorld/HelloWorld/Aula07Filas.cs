using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aula07Filas
    {
        static void Aula07()
        {
            // Filas = O primeiro que chega é o primeiro que sai

            Queue fila = new Queue();
            fila.Enqueue("Fabrício");
            fila.Enqueue("Beatriz");
            fila.Enqueue("Patinhas");
            fila.Enqueue("Musk");

            WriteLine(fila.Peek());

            WriteLine($"A fila tem {fila.Count} item");
            WriteLine($"O item {fila.Dequeue()} foi retirado");
            WriteLine($"A fila tem {fila.Count} item");
            WriteLine($"O item {fila.Dequeue()} foi retirado");
        }
    }
}
