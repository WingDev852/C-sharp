namespace voorspel_de_volgorde
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
            Console.WriteLine("Dag {naam}!"); // deze heb verkeerd omdat ik dacht dat het een error ging worden, maar dat werd gewoon een string.
            Console.Write("Tot");
            Console.WriteLine("ziens");
            Console.WriteLine();
            Console.WriteLine("Einde");
        }
    }
}
