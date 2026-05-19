using System.Globalization;

namespace ProgramaAluno
{
    class Program
    {
        public static void Main(string [] args)
        {
            Aluno aluno = new Aluno();

            System.Console.WriteLine("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite as tres notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine(aluno);
        }
    }
}
