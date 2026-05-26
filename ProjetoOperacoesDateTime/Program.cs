using System.Xml.Serialization;

namespace OperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();

            string s5 = d2.ToString();

            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
            System.Console.WriteLine(s3);
            System.Console.WriteLine(s4);
            System.Console.WriteLine(s5);
            System.Console.WriteLine(s6);
            System.Console.WriteLine(s7);

            d2.AddDays(2);

            DateTime dt1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dt2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dt3 = new DateTime(2000, 8, 15, 13, 5, 58);

            System.Console.WriteLine("d1: " + dt1);
            System.Console.WriteLine("d1 Kind: " + dt1.Kind);
            System.Console.WriteLine("d1 to Local: " + dt1.ToLocalTime());
            System.Console.WriteLine("d1 to Utc: " + dt1.ToUniversalTime());
        }
    }
}