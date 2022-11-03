using System.Collections;
using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
        {

            double salario = 0;
            double gastosMensais = 0;
            bool temDecimoTerceiro = false;

            Write("Informe seu salario: ");
            salario = Convert.ToDouble(ReadLine());
            Write("Informe seu gastos mensais: ");
            gastosMensais = Convert.ToDouble(ReadLine()); 
            Write("Tem decímo terceiro? ");
            Boolean.TryParse(ReadLine(), out temDecimoTerceiro);

            if (temDecimoTerceiro)
            {
                salario += salario;
            }

            if (gastosMensais > salario)
            {
                WriteLine("Precisa economizar!");
            }else if (gastosMensais == salario)
            {
                WriteLine("Ufaa! foi por pouco");
            }
            else
            {
                WriteLine("Sobrou dinheiro!!");
            }
        }
    }
}