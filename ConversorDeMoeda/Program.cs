using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string [] args)
        {
            System.Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Quantos dólares você vai comprar?");
            double valorDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Valor a ser pago em reais = " + Conversor.Converter(cotacao, valorDolares));
        }
    }
}
