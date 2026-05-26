using System.Data.Common;
using System.Runtime.ConstrainedExecution;
using ProjetoOrders.Entities;
using ProjetoOrders.Entities.Enums;


namespace ProjetoOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            System.Console.WriteLine(txt);
            System.Console.WriteLine(os);
        }
    }
}