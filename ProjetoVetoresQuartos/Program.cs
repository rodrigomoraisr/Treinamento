namespace ProjetoVetoresQuartos
{
    class Program
    {
        static void Main(string [] args)
        {
            System.Console.Write("Quantos quartos serao alugados?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Reserva [] reservas = new Reserva[10];

            for(int i = 0; i < qtdQuartos; i++)
            {
                System.Console.Write("Nome: ");
                string name = Console.ReadLine();
                System.Console.Write("E-mail: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                reservas[room] = new Reserva{ Name = name, Email = email, Room = room};
            }

            System.Console.WriteLine("Quantos Ocupados:");

            for(int i = 0; i < 10; i++)
            {
                if(reservas[i] != null)
                {
                    System.Console.WriteLine(reservas[i]);
                }
            }
        }
    }
}