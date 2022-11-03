using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
        {
            // Pilhas = O que entra por último sai primeiro

            Stack<int> p1 = new Stack<int>();

            // Coloca itens dentro da pilha
            p1.Push(2);
            p1.Push(3);
            p1.Push(5);
            p1.Push(7);
            p1.Push(11);

            WriteLine($"A pilha tem {p1.Count} itens");
            //WriteLine(p1.ToArray().GetValue(4));
            WriteLine(p1.Peek()); // Pega o ultimo elemento

            p1.Pop(); // Retira o item da pilha

            WriteLine($"A pilha tem {p1.Count} itens");

            WriteLine(p1.Count); // Quantidade de itens na pilha
            //WriteLine(p1.ToArray().GetValue(3));
            WriteLine(p1.Peek());
        }
    }
}