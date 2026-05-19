using System.Globalization;

namespace ProjetoFuncionario
{
    class Program
    {
        public static void Main(string [] args)
        {
            Funcionario funcionario = new Funcionario();

            System.Console.WriteLine("Nome do Funcionario: ");
            funcionario.Nome = Console.ReadLine();

            System.Console.WriteLine("Salario bruto");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Imposto");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Funcionário: " + funcionario);

            System.Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            System.Console.WriteLine("Dados Atualizados: " + funcionario);

        }
    }
}
