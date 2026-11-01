namespace Euro_naar_Dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bedragInEuro = 78.65;
            double bedragInDollar = bedragInEuro * 1.03;

            Console.WriteLine(bedragInDollar);

            Console.ReadLine();
        }
    }
}
