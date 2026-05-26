using System.Globalization;

namespace ProjetoDateTime
{
    class Program
    {
        static void Main(string [] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
            System.Console.WriteLine(d3);
            System.Console.WriteLine(d4);
            System.Console.WriteLine(d5);
            System.Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            System.Console.WriteLine(d7);
            System.Console.WriteLine(d8);
            System.Console.WriteLine(d9);
            System.Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            System.Console.WriteLine(d11);
            System.Console.WriteLine(d12);
        }
    }
}
