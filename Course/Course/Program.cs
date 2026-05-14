using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100; // -128 a 127
            byte n1 = 255; // 0 a 255
            short n2 = 30000; // -32.768 a 32.767
            ushort n3 = 60000; // 0 a 65.535
            int n4 = 2000000000; // -2.147.483.648 a 2.147.483.647
            uint n5 = 4000000000u; // 0 a 4.294.967.295
            long n6 = 9000000000000000000L; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            ulong n7 = 18000000000000000000UL; // 0 a 18.446.744.073.709.551.615
            float n8 = 1.5f; // ±1.5e-45 a ±3.4e38
            double n9 = 1.5; // ±5.0e-324 a ±1.7e308
            decimal n10 = 1.5m; // ±1.0e-28 a ±7.9e28
            char c = 'A'; // U+0000 a U+FFFF
            char c2 = '\u0041'; // U+0000 a U+FFFF - utilizando código Unicode
            bool b = true; // true ou false

            n1++;
            Console.WriteLine(n1);
            System.Console.WriteLine(n1.GetType());

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria Silva";

            Console.Write("Bom dia!");     
            Console.WriteLine("Boa tarde!");  
            Console.WriteLine("Boa noite!");   

            Console.WriteLine("------------------------------");  
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            Console.WriteLine(saldo.ToString("F2")); // Formata o número com 2 casas decimais
            Console.WriteLine(saldo.ToString("F4")); // Formata o número com 4 casas decimais
            Console.WriteLine(saldo.ToString("F6")); // Formata o número com 6 casas decimais
            Console.WriteLine(saldo.ToString("C")); // Formata o número como moeda
            Console.WriteLine(nome.ToString().ToUpper()); // Converte o nome para maiúsculas
            Console.WriteLine(nome.ToString().ToLower()); // Converte o nome para minúsculas
            Console.WriteLine(nome.ToString().Trim()); // Remove espaços em branco do início e do fim do nome

            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); 
            // Formata o número com 2 casas decimais e utiliza o ponto como separador decimal 

            Console.WriteLine("{0} tem {1} anos e saldo igual a {2:F2} reais.", nome, idade, saldo); //Placeholder

            Console.WriteLine($"{nome} tem {idade} anos e saldo igual a {saldo:F2} reais."); //Interpolação de string   

            Console.WriteLine(nome + " tem " + idade + " anos e saldo igual a " + saldo.ToString("F2") + " reais."); //Concatenação de string   

            float a = 4.5f;
            double b = a; // Conversão implícita de float para double
            Console.WriteLine(b);

            double c1 = 4.5;
            float d = (float)c1; // Conversão explícita de double para float
            Console.WriteLine(d);

            int i ;
            int i = (int)3.14; // Conversão explícita de double para int
            Console.WriteLine(i);

            int j = 5;
            int h = 2;
            double resultado = j / h; // Divisão entre dois inteiros resulta em um inteiro (2)
            Console.WriteLine(resultado);
            double resultado = (double)j / h; // Conversão explícita de int para double antes da divisão
            Console.WriteLine(resultado);

            int num1 = 3+4*2; // A multiplicação tem precedência sobre a adição, então o resultado é 11
            Console.WriteLine(num1);

            int num2 = (3+4)*2; // Os parênteses alteram a ordem de avaliação, então o resultado é 14
            Console.WriteLine(num2);

            int num3 = 10 % 3; // O operador de módulo retorna o resto da divisão, então o resultado é 1    
            Console.WriteLine(num3);

            int num4 = 10.0 % 3.0; // O operador de módulo também pode ser usado com números de ponto flutuante, então o resultado é 1.0    
            Console.WriteLine(num4);

           double num5 = 10.0 / 8.0; // O resultado é 1.25
           Console.WriteLine(num5);

           double a = 1.0, b = -3.0, c = -4.0;
           //double delta = Math.Pow(b, 2) - 4.0 * a * c;
           double delta = b * b - 4.0 * a * c; // Calcula o valor de delta
           if (delta < 0.0)
           {
               Console.WriteLine("Não existem raízes reais.");
           }
           else
           {
               double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Calcula a primeira raiz
               double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); // Calcula a segunda raiz
               Console.WriteLine("As raízes são: " + x1 + " e " + x2);  
           }
        }
    }
}