using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ProjetoRetangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Altura, 2)) + (Math.Pow(Largura, 2)));
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
            + "\nPERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
            + "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}