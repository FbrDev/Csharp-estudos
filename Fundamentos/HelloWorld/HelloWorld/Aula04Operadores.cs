using static System.Console;

namespace HelloWorld
{
    internal class Aula04Operadores
    {
        static void Aula04()
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
