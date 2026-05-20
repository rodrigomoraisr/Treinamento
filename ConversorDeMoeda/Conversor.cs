using System.Runtime.CompilerServices;

namespace ConversorDeMoeda
{
    class Conversor
    {
        public static double IOF = 6.0;

        public static double Converter(double cotacao, double valorDolar)
        {
            double valorReais = cotacao * valorDolar;
            return valorReais + (valorReais * (IOF / 100));          
        }
    }
}