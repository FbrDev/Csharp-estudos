using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aula10SwitchCase
    {
        public static void Aula10()
        {
            WriteLine("SWITCH CASE");
            Write("Informe o saldo do cartão/banco: ");
            double eSaldo = Convert.ToDouble(ReadLine());

            Write("Informe o valor da compra: ");
            double eValor = Convert.ToDouble(ReadLine());

            Write("Informe o tipo de pagamento (C para Crédito e D para Débito): ");
            char eTipo = Convert.ToChar(ReadLine());

            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            //pattern mapping
            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com o cartão de crédito não aprovada");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com o cartão de débito não aprovada");
                    break;
                default:
                    WriteLine("Compra Aprovada!");
                    break;
            }

            /*switch (eTipo)
            {
                case 'C':
                    WriteLine("Compra com Cartão de crédito");
                    break;
                case 'D':
                    WriteLine("Compra com Cartão de Débito");
                    break;
                default:
                    WriteLine("Compra com dinheiro");
                    break;
            }*/
            WriteLine("======================================");
        }
    }
}
