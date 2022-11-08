using System.Globalization;

namespace AvancandoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Hoje à noite, sem luz, decidi xeretar a quinta gaveta de vovô: achei linguiça, pão e fubá";

            Console.WriteLine(frase.Length); // Conta quantos caracteres

            string[] partes = frase.Split(","); // Quebra a frase em pedaços com base em um caractere
            for(var i = 0; i < partes.Length; i++)
            {
                Console.WriteLine(partes[i].Trim()); // Retira os espaços
            }

            string subFrase = "quinta";
            Console.WriteLine(frase.Contains(subFrase)); // retorna um boolean caso encontre a frase

            int pos = frase.IndexOf(subFrase); // Mostra a posição da palavra

            string sub = frase.Substring(pos);
            Console.WriteLine(sub);

            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());

            string fraseTrocada = frase.Replace("Vovô", "mamãe", true, CultureInfo.CurrentCulture);
            Console.WriteLine(fraseTrocada.Trim());

        }
    }
}