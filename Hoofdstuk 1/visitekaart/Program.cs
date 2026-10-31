namespace visitekaart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw voornaam");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Wat is uw achternaam");
            string achternaam = Console.ReadLine();
            Console.WriteLine("Waar woon je");
            string woonplaats = Console.ReadLine();
            Console.WriteLine("Wat is jouw hobby?");
            string hobby = Console.ReadLine();

            Console.WriteLine("Goed. Hier volgt de visite kaartje");

            /*Console.Write("naam:");
            Console.Write(voornaam);
            Console.WriteLine(achternaam);
            Console.Write("Adres:");
            Console.WriteLine(woonplaats);
            Console.Write("Hobby:");
            Console.Write(hobby);
            */

            Console.WriteLine($"naam: {voornaam} {achternaam}");
            Console.WriteLine($"Adres: {woonplaats}");
            Console.WriteLine($"Hobby: {hobby}");
            

        }
    }
}
