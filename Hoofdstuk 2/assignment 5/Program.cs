namespace assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prijs = 20;
            const double BTW = 21.0;

            double prijsBTW = prijs * (1 + BTW / 100);

            Console.WriteLine($"Prijs {prijs} euro zonder btw. Met BTW: {prijsBTW} euro.");
        }
    }
}
