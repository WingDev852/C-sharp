namespace assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hier komt het!");
            Console.WriteLine("Geef een naam:");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef een zelfstandig naamwoord:");
            string zelfstNw = Console.ReadLine();
            Console.WriteLine("Geef een adjectief:");
            string adjectief = Console.ReadLine();
            Console.WriteLine("Geef een werkwoord:");
            string werkwoord = Console.ReadLine();
            Console.WriteLine("Geef een uitroep:");
            string uitroep = Console.ReadLine();

            Console.WriteLine("\nHier komt het!\n");
            Console.WriteLine($"Op een dag ging {naam} naar de AP Hogeschool. Hij zag daar een {adjectief} {zelfstNw} " +
                              $"en vond dat zo grappig dat hij begon te {werkwoord}. Toen de docent vroeg wat er zo " +
                              $"grappig was, riep {naam} \"{uitroep}!\" De naam {naam} telt {naam.Length} letters.");
        }
    }
}
