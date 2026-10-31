namespace Wie_ben_ik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Vincent van camp");
            Console.WriteLine("Boom");
            Console.WriteLine("60");*/

           Console.WriteLine("Vincent van camp");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
           Console.WriteLine("Boom");
            Console.ResetColor();
           Console.WriteLine("60");

        }
    }
}
