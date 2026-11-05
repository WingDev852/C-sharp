namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int artikelnummer = 4217;
            string omschrijving = "Jonge kaas";
            double gewicht = 0.45;          // in kg
            double prijsPerKilo = 27.44;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("******************************\r\n");
            Console.WriteLine($"Artikel:\t {artikelnummer:D6}");
            Console.WriteLine($"Omschrijving:\t {omschrijving}");
            Console.WriteLine($"gewicht:\t {gewicht:F3}");
            Console.WriteLine($"Prijs per kg:\t €{prijsPerKilo}");
            Console.WriteLine($"Te betalen:\t €{prijsPerKilo*gewicht}");
        }
    }
}
