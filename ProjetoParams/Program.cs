using System;

namespace ProjetoParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
            
            int a = 10;
            Calculator.Triple(ref a);
            System.Console.WriteLine(a);

            int b = 20;
            int triple;
            Calculator.TripleOut(b, out triple);
            System.Console.WriteLine(triple);
        }
    }
}