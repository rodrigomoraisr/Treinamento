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
            double db = a; // Conversão implícita de float para double
            Console.WriteLine(db);

            double c1 = 4.5;
            float d = (float)c1; // Conversão explícita de double para float
            Console.WriteLine(d);

            int i;
            i = (int)3.14; // Conversão explícita de double para int
            Console.WriteLine(i);

            int j = 5;
            int h = 2;
            double resultado = j / h; // Divisão entre dois inteiros resulta em um inteiro (2)
            Console.WriteLine(resultado);
            resultado = (double)j / h; // Conversão explícita de int para double antes da divisão
            Console.WriteLine(resultado);

            int num1 = 3 + 4 * 2; // A multiplicação tem precedência sobre a adição, então o resultado é 11
            Console.WriteLine(num1);

            int num2 = (3 + 4) * 2; // Os parênteses alteram a ordem de avaliação, então o resultado é 14
            Console.WriteLine(num2);

            int num3 = 10 % 3; // O operador de módulo retorna o resto da divisão, então o resultado é 1    
            Console.WriteLine(num3);

            int num4 = (int)(10.0 % 3.0); // O operador de módulo também pode ser usado com números de ponto flutuante, então o resultado é 1.0    
            Console.WriteLine(num4);

            double num5 = 10.0 / 8.0; // O resultado é 1.25
            Console.WriteLine(num5);

            double ae = 1.0, be = -3.0, ce = -4.0;
            //double delta = Math.Pow(be, 2) - 4.0 * ae * ce;
            double delta = be * be - 4.0 * ae * ce; // Calcula o valor de delta
            if (delta < 0.0)
            {
                Console.WriteLine("Não existem raízes reais.");
            }
            else
            {
                double x1 = (-be + Math.Sqrt(delta)) / (2.0 * ae); // Calcula a primeira raiz
                double x2 = (-be - Math.Sqrt(delta)) / (2.0 * ae); // Calcula a segunda raiz
                Console.WriteLine("As raízes são: " + x1 + " e " + x2);
            }

            string frase = Console.ReadLine(); // Lê uma linha de texto do console e armazena na variável frase
            string cor1 = Console.ReadLine(); // Lê uma linha de texto do console e armazena na variável cor1
            string cor2 = Console.ReadLine(); // Lê uma linha de texto do console e armazena na variável cor2
            string cor3 = Console.ReadLine();

            Console.WriteLine("Você digitou: " + frase); // Exibe a frase digitada pelo usuário no console
            Console.WriteLine("Você digitou: " + cor1); // Exibe a cor1 digitada pelo usuário no console
            Console.WriteLine("Você digitou: " + cor2); // Exibe a cor2 digitada pelo usuário no console
            Console.WriteLine("Você digitou: " + cor3); // Exibe a cor3 digitada pelo usuário no console

            string s = Console.ReadLine(); // Lê uma linha de texto do console e armazena na variável s
            string[] vet = s.Split(' '); // Divide a string s em um array de strings usando o espaço como separador
            string a1 = vet[0]; // Acessa o primeiro elemento do array vet e armazena na variável a1
            string b1 = vet[1]; // Acessa o segundo elemento do array vet e armazena na variável b1
            string c5 = vet[2]; // Acessa o terceiro elemento do array vet e armazena na variável c1 

            Console.WriteLine("Você digitou: " + a1); // Exibe a1 digitada pelo usuário no console
            Console.WriteLine("Você digitou: " + b1); // Exibe b1 digitada pelo usuário no console
            Console.WriteLine("Você digitou: " + c5); // Exibe c5 digitada pelo usuário no console

            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + x3);

            string[] vet2 = Console.ReadLine().Split(' ');
            string vetNome = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int vetIdade = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: " + vetNome);
            Console.WriteLine("Você digitou: " + sexo);
            Console.WriteLine("Você digitou: " + vetIdade);
            Console.WriteLine("Você digitou: " + altura.ToString("F2", CultureInfo.InvariantCulture));

            //Operadores relacionais e lógicos
            //Ordem de precedência: ! > && > ||
            int valor = 10;
            bool cond1 = valor < 10;
            bool cond2 = valor < 20;
            bool cond3 = valor > 10;
            bool cond4 = valor > 5;

            Console.WriteLine(cond1);
            Console.WriteLine(cond2);
            Console.WriteLine(cond3);
            Console.WriteLine(cond4);
            Console.WriteLine("------------------------------");

            bool cond5 = valor <= 10;
            bool cond6 = valor >= 10;
            bool cond7 = valor == 10;
            bool cond8 = valor != 10;

            Console.WriteLine(cond5);
            Console.WriteLine(cond6);
            Console.WriteLine(cond7);
            Console.WriteLine(cond8);
            Console.WriteLine("------------------------------");

            bool cond9 = 2 > 3 && 5 != 5;
            bool cond10 = 2 > 3 || 5 != 5;

            Console.WriteLine(cond9);
            Console.WriteLine(cond10);

            bool cond11 = !(2 > 3) && !(5 != 5);
            Console.WriteLine(cond11);

            int comp = 10;

            System.Console.WriteLine("Bom dia");

            if (comp > 5)
            {
                System.Console.WriteLine("Boa tarde");
            }
            else
            {
                System.Console.WriteLine("Boa noite");
            }

            System.Console.WriteLine("Entre com um número inteiro:");
            int numInt = int.Parse(Console.ReadLine());

            if (numInt % 2 == 0)
            {
                System.Console.WriteLine("O número é par.");
            }
            else
            {
                System.Console.WriteLine("O número é ímpar.");
            }

            System.Console.WriteLine("Qual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                System.Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                System.Console.WriteLine("Boa tarde!");
            }
            else
            {
                System.Console.WriteLine("Boa noite!");
            }

            //Escopo de variáveis
            int x4 = 10; // Variável declarada no escopo do método Main
            if (x4 > 5)
            {
                int y = 20; // Variável declarada no escopo do bloco if
                Console.WriteLine("x4: " + x4);
                Console.WriteLine("y: " + y);
            }
            // Console.WriteLine("y: " + y); // Erro de compilação: y não é acessível fora do bloco if

            System.Console.WriteLine("Digite tres números inteiros:");
            string[] numeros = Console.ReadLine().Split(' ');
            int mn1 = int.Parse(numeros[0]);
            int mn2 = int.Parse(numeros[1]);
            int mn3 = int.Parse(numeros[2]);

            if (mn1 > mn2 && mn1 > mn3)
            {
                System.Console.WriteLine("O maior número é: " + mn1);
            }
            else if (mn2 > mn1 && mn2 > mn3)
            {
                System.Console.WriteLine("O maior número é: " + mn2);
            }
            else
            {
                System.Console.WriteLine("O maior número é: " + mn3);
            }

            double resultadoMaior = ObterMaior(mn1, mn2, mn3);
            System.Console.WriteLine("O maior número é: " + resultadoMaior);

            Console.WriteLine("Digite um número inteiro:");
            double numDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numDouble >= 0.0)
            {
                double raizQuadrada = Math.Sqrt(numDouble); // Calcula a raiz quadrada de numDouble
                Console.WriteLine("A raiz quadrada de " + numDouble + " é: " + raizQuadrada.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número inteiro (ou um número negativo para sair):");
                numDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            System.Console.WriteLine("Programa encerrado. Você digitou um número negativo.");

            System.Console.WriteLine("Quantos números inteiros você deseja digitar?");
            int quantidade = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int l = 0; l <= quantidade; l++)
            {
                Console.WriteLine("Valor #{0}: ", l);
                int valorLido = int.Parse(Console.ReadLine());
                soma += valorLido; // Soma o valor lido à variável soma
            }
            System.Console.WriteLine("A soma dos números é: " + soma);
        }

        static int ObterMaior(int a, int b, int c)
        {
            int maior = a;
            if (b > maior)
            {
                maior = b;
            }
            if (c > maior)
            {
                maior = c;
            }
            return maior;
        }
    }
}