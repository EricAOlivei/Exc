using System;
using Exc.Entities;
using Exc.Entities.Exceptions;
using System.Globalization;

namespace Exc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter reservation data: ");
                Console.WriteLine();

                Console.Write("Room number: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyy): ");
                DateTime dateIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyy): ");
                DateTime dateOut = DateTime.Parse(Console.ReadLine());

                Console.Clear();

                Reservation reservation = new Reservation(n, dateIn, dateOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Enter data to update the reservatin : ");
                Console.WriteLine();

                Console.Write("Check-in date (dd/MM/yyy): ");
                dateIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyy): ");
                dateOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(dateIn, dateOut);
                Console.WriteLine("Reservation: " + reservation);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}