using System.Globalization;
using System;

namespace MembrosEstaticos{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }       
    }
}
