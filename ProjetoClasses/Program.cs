using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using ProjetoClasses;

class Program
{
    static void Main(string[] args)
    {
        Triangulo x, y;
        x = new Triangulo();
        y = new Triangulo();

        System.Console.WriteLine("Entre com as medidas do triangulo X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("Entre com as medidas do triangulo Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.Area();
        
        double areaY = y.Area();

        System.Console.WriteLine("Área do X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        System.Console.WriteLine("Área do Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            System.Console.WriteLine("Maior area: X");
        }
        else
        {
            System.Console.WriteLine("Mario area: Y");
        }

        Pessoa pessoa1, pessoa2;
        pessoa1 = new Pessoa();
        pessoa2 = new Pessoa();

        System.Console.WriteLine("Insira o nome da pessoa 1: ");
        pessoa1.Nome = Console.ReadLine();
        System.Console.WriteLine("Insira a idade da pessoa 1: ");
        pessoa1.Idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Insira o nome da pessoa 2: ");
        pessoa2.Nome = Console.ReadLine();
        System.Console.WriteLine("Insira a idade da pessoa 2: ");
        pessoa2.Idade = int.Parse(Console.ReadLine());

        string pessoaMaisVelha;

        if(pessoa1.Idade > pessoa2.Idade)
        {
            pessoaMaisVelha = pessoa1.Nome;
        }
        else
        {
            pessoaMaisVelha = pessoa2.Nome;
        }

        System.Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);

        Funcionario func1, func2;
        func1 = new Funcionario();
        func2 = new Funcionario();

        System.Console.WriteLine("Nome do primeiro funcionario: ");
        func1.Nome = Console.ReadLine();
        System.Console.WriteLine("Salario do primeiro funcionario: ");
        func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("Nome do segundo funcionario: ");
        func2.Nome = Console.ReadLine();
        System.Console.WriteLine("Salario do segundo funcionario: ");
        func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salarioMedio = (func1.Salario + func2.Salario) / 2;

        System.Console.WriteLine("Salario Médio = {0}", salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
    }
}