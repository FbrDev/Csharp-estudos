using System.Collections;
using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
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