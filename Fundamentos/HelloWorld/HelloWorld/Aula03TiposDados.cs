using static System.Console;
namespace HelloWorld
{
    internal class Aula03TiposDados
    {
        static void Aula03()
        {
            char status = 'A'; //Armazena apenas um caractere
            bool ativo = true; //Verdadeiro/falso
            byte numero = 1;// 0 a 255;
            sbyte negativo = -1; // -128 até 127
            short valoresNegativoPequeno = -318;
            ushort valoresPositivoPequeno = 318;
            int ValoresNegativo = -39299;
            uint ValoresPositivo = 381931031;
            decimal temperatura = 2.0m;
            //double temperatura = 30.0;
            //float temperatura = 20.14f;

            WriteLine(status.GetType()); // Mostra o tipo da váriavel
            WriteLine(ValoresNegativo.GetType().IsPrimitive); // Verifica se é um tipo primitivo


            int n1 = 10;
            long n2 = n1;
            short n3 = (short)n1; //Necessário converter de forma explicita
            WriteLine(n2);
            WriteLine(n3);
        }
    }
}
