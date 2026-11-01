namespace assignment_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string raadsel = "Wat wordt natter naarmate het meer droogt";
            string antwoord = "Een handdoek!";

            Console.WriteLine(raadsel);
            Console.WriteLine("Druk op enter voor het antwoord");
       
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(antwoord);
            Console.ResetColor();
        }
    }
}
