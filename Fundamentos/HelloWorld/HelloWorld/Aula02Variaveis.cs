using static System.Console;

namespace HelloWorld
{
    internal class Aula02Variaveis
    {
        public static void Aula02()
        {
            WriteLine("VARIAVEIS");

            int idade = 21;
            string nome = "Fabrício Pereira";
            bool ativo = false;
            decimal salario = 1345.98m;
            float descontos = 397.99f;
            var cidade = "São Paulo";

            WriteLine($"O usuário {nome} tem {idade} anos de idade, está {ativo} no sistema ganha {salario} por mês. Tem desconto de {descontos} e mora na cidade de {cidade}");
            WriteLine("\n-------------------------\n");

            dynamic x = "Essa variável é uma string";
            WriteLine(x);
            x = 10;
            WriteLine(x);
            x = true;
            WriteLine(x);

            WriteLine("======================================");
        }
    }
}
