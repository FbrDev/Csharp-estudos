using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
        {
            var x = 10;
            var y = 5;

            var soma = x + y;
            var subtrair = x - y;
            var multiplicar = x * y;
            var dividir = x / y;
            

            soma += subtrair;
            soma -= subtrair;
            soma *= subtrair;
            soma /= subtrair;
            soma %= subtrair;

            var resto = 7 % 3; // Pega o resto da divisão

            WriteLine(soma);
            WriteLine(subtrair);
            WriteLine(multiplicar);
            WriteLine(dividir);
            WriteLine(resto);

            var i = 0;

            //Pós-incrementado
            i++;
            i--;

            //Pré-incrementado
            ++i;
            --i;
        }
    }
}