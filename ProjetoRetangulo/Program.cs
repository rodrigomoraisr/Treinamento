using System.Globalization;

namespace ProjetoRetangulo
{
    class Program{
        public static void Main(String[] args)
        {
            Retangulo retangulo = new Retangulo();

            System.Console.WriteLine("Entre a altura do retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre a largura do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area();
            double Perimetro = retangulo.Perimetro();
            double Diagonal = retangulo.Diagonal();

            System.Console.WriteLine(retangulo);
        }

    }
}