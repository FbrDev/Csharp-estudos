using System.Globalization;

namespace AvancandoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Fabricio";
            int idade = 21;
            double rendimento = 433012.02;
            DateTime dataCadastro = new DateTime(2000,04,02);

            string frase = "O cliente {0} tem {1} anos de idade, o redimento dele é {2:c} ";
            frase += "é cliente desde de {3:dd/MM/yyyy}";

            frase = String.Format(frase, nome, idade, rendimento, dataCadastro);

            Console.WriteLine(frase);
        }
    }
}