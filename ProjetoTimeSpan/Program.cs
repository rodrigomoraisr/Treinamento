using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace ProjetoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1,2,11,21);
            TimeSpan t5 = new TimeSpan(1,2,11,21,321);

            System.Console.WriteLine(t1);
            System.Console.WriteLine(t2);
            System.Console.WriteLine(t3);
            System.Console.WriteLine(t4);
            System.Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            System.Console.WriteLine(t6);
            System.Console.WriteLine(t7);
            System.Console.WriteLine(t8);
            System.Console.WriteLine(t9);
            System.Console.WriteLine(t10);
            System.Console.WriteLine(t11);

            TimeSpan ts = new TimeSpan(2, 3, 5, 7, 11);

            System.Console.WriteLine(ts);
            Console.WriteLine("Days: " + t1.Days);
            Console.WriteLine("Hours: " + t1.Hours);
            Console.WriteLine("Minutes: " + t1.Minutes);
            Console.WriteLine("Milliseconds: " + t1.Milliseconds);
            Console.WriteLine("Seconds: " + t1.Seconds);
            Console.WriteLine("Ticks: " + t1.Ticks);

            Console.WriteLine("TotalDays: " + t1.TotalDays);
            Console.WriteLine("TotalHours: " + t1.TotalHours);
            Console.WriteLine("TotalMinutes: " + t1.TotalMinutes);
            Console.WriteLine("TotalMilliseconds: " + t1.TotalMilliseconds);
            Console.WriteLine("TotalSeconds: " + t1.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t1.TotalMilliseconds);

            TimeSpan ts1 = new TimeSpan(1,30,10);
            TimeSpan ts2 = new TimeSpan(0,10,5);

            TimeSpan sum = ts1.Add(ts2);
            TimeSpan dif = ts1.Subtract(ts2);
            TimeSpan mult = ts2.Multiply(2.0);
            TimeSpan div = ts2.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}