namespace assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double frieten = 4.50;
            double hapje = 12.00;
            double cola = 2.50;

            int aantalFrieten = 2;
            int aantalCola = 3;
            int aantalHapje = 1;


            double totaalBedrag = (frieten*aantalFrieten) + (hapje*aantalHapje) + (cola * aantalCola);

            double gemiddelde = totaalBedrag / (aantalFrieten + aantalCola + aantalHapje);

            const double wisselkoers = 1.08;

            Console.WriteLine("Kassa wordt geladen... druk op enter");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("KASSATICKET");
            Console.WriteLine("*************************");
            Console.WriteLine($"{aantalFrieten} x Friet       :{frieten * aantalFrieten} euro");
            Console.WriteLine($"{aantalHapje} x Hapje       :{hapje * aantalHapje} euro");
            Console.WriteLine($"{aantalCola} x Cola        :{cola * aantalCola} euro");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Totaal (EUR) :{totaalBedrag} euro");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Totaal (USD) :{totaalBedrag*wisselkoers} dollar");
            Console.ResetColor();
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Gemiddelde/prod :{gemiddelde} euro");
            Console.WriteLine("*************************");



        }
    }
}
