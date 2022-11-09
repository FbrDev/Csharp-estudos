using System.Globalization;
using System.Text;

namespace AvancandoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataDoBanco = "2018-04-02 08:30:00";
            //DateTime data = new DateTime(2018, 04, 02, 08, 30, 00);
            DateTime data = DateTime.Parse(dataDoBanco);

            string horaFormatada = String.Format("{0:HH}h{0:mm}", data);
            string dataFormatada = String.Format("{0:dd}/{0:MM}/{0:yyyy}", data);

            Console.WriteLine(dataFormatada);
        }
    }
}