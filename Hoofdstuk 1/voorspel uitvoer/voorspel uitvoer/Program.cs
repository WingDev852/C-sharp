namespace voorspel_uitvoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hallo");
            Console.WriteLine("wereld");
            Console.Write("Wie ben jij? ");
            string naam = Console.ReadLine();
            Console.Write("Dag ");
            Console.WriteLine("naam");
            Console.WriteLine($"Dag {naam}!");
            Console.WriteLine("Dag {naam}!");
            Console.Write("Tot");
            Console.WriteLine("ziens");
            Console.WriteLine();
            Console.WriteLine("Einde");
        }
    }
}
