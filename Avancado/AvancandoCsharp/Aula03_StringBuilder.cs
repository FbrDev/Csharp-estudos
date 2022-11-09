using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvancandoCsharp
{
    internal class Aula03_StringBuilder
    {
        static void Aula03()
        {
            StringBuilder builder = new StringBuilder("Adicionando uma frase inicial");
            builder.Append("Adicionando mais uma frase na mesma linha");
            builder.AppendLine("Adicionando frase com quebra linha");
            builder.Append("Adicionando frase após o quebra linha");

            Console.WriteLine(builder.ToString());

            string nome = "Fabricio";
            int idade = 21;
            double rendimento = 433012.02;
            DateTime dataCadastro = new DateTime(2000, 04, 02);

            StringBuilder frase = new StringBuilder("\n\nO cliente {0} tem {1} anos de idade, o redimento dele é {2:c} ");
            frase.Append("é cliente desde de {3:dd/MM/yyyy}");
            builder.AppendFormat(frase.ToString(), nome, idade, rendimento, dataCadastro);

            Console.WriteLine(builder.ToString());
        }
    }
}
