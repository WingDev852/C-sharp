using System.Globalization;

namespace final_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de filmtitel:");
            string film = Console.ReadLine();
            Console.Write("Geef de prijs:");
            string prijs = Console.ReadLine();
            Console.Write("Geef je naam:");
            string naam = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("------------------------------");
            Console.ResetColor();
            Console.Write("Film: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(film);
            Console.ResetColor();
            Console.Write("Prijs: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(prijs);
            Console.ResetColor();
            Console.Write("Naam: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(naam);
            Console.ResetColor();
        }
    }
}
