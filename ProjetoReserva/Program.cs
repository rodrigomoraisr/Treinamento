using ProjetoReserva.Entities;

Console.Write("Room number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Check-in date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());
Console.Write("Check-out date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());

if (checkOut <= checkIn)
{
    Console.Write("Error in reservation: Check-out date must be after check-in date");
}
else
{
    Reservation reservation = new Reservation(number, checkIn, checkOut);
    System.Console.WriteLine("Reservation: " + reservation);
    System.Console.WriteLine();
    System.Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    DateTime now = DateTime.Now;
    if (checkIn < now || checkOut < now)
    {
        System.Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
    }
    else if (checkOut <= checkIn)
    {
        Console.Write("Error in reservation: Check-out date must be after check-in date");
    }
    else
    {
        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Resevation: " + reservation);
    }
}

