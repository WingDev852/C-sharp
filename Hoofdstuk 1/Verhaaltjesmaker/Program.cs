namespace Verhaaltjesmaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Geef een kleur");
             string kleur = Console.ReadLine();
             Console.WriteLine("Geef een eten");
             string eten = Console.ReadLine();
             Console.WriteLine("Geef een dier");
             string dier = Console.ReadLine();
             Console.WriteLine("Geef een stad");
             string stad = Console.ReadLine();


             Console.WriteLine($"Er was eens een {dier} uit {stad}. Elke dag at hij {eten}, en alles in zijn huis was {kleur}.");*/

            Console.WriteLine("Geef een kleur:");
            string kleur = Console.ReadLine();
            Console.WriteLine("Geef een eten:");
            string eten = Console.ReadLine();
            Console.WriteLine("Geef een dier:");
            string stad = Console.ReadLine();
            Console.WriteLine("Geef een stad:");
            string dier = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Er was eens een {dier} uit {stad}. Elke dag at hij {eten}, en alles in zijn huis was {kleur}.");

            //eten en dier is van plaats gewisseld waardoor die een verkeerde input heeft
        }
    }
}
