using System.Globalization;

namespace ProgramaAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            if(NotaFinal() >= 60.0)
            {
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) 
                + "\n APROVADO";
            }
            else
            {
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) 
                + "\n REPROVADO"
                + $"\nFALTARAM {60.0 - NotaFinal()} PONTOS" ;
            }
        }
    }
}