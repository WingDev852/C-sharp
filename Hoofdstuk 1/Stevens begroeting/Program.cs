namespace Stevens_begroeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Waar woon je?");
            string stad = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dag {naam} uit {stad}!");
            Console.ResetColor();
            Console.Write("Tot");
            Console.WriteLine("ziens.");
        }
    }
}
