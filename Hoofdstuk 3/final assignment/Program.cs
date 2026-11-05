namespace final_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double prijsTicket = 249.99;

            Console.WriteLine("Boardingpass generator \n********************** ");

            Console.WriteLine("Naam passagier:");
            string naam = Console.ReadLine();
            Console.WriteLine("Vertrekplaats?");
            string vertrekPlaats  = Console.ReadLine();
            Console.WriteLine("Bestemming?");
            string bestemming = Console.ReadLine();
            Console.WriteLine("Wat is uw gate?");
            string gate = Console.ReadLine();

            Console.WriteLine("Scherm wordt leeg gemaakt...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("****************************************\nBOARDINGPASS\n****************************************");
            Console.WriteLine($"Passagier:\t{naam}");
            Console.WriteLine($"Van:\t{vertrekPlaats}");
            Console.WriteLine($"Naar:\t{bestemming}");
            Console.WriteLine($"Gate:\t{gate}");
            Console.WriteLine($"Prijs\t{prijsTicket}");

            Console.WriteLine("Vluchtgegevens gecontroleerd door:" + Environment.UserName);
            Console.WriteLine("****************************************\r\n");

        }
    }
}
