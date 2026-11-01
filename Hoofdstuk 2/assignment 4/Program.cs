namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int september = 224;
            int oktober = 177;
            int november = 210;

            double gemiddeld = ((double)september + (double)oktober + (double)november) / 3;

            Console.WriteLine($"Je sliep gemiddeld: {gemiddeld} uren per maand.");
        }
    }
}
