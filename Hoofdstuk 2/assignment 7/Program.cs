namespace assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DOOS_GROOTTE = 8;
            int aantalEieren = 124;

            int dozijn = aantalEieren / DOOS_GROOTTE;

            int rest = aantalEieren % DOOS_GROOTTE;

            Console.WriteLine($"{aantalEieren} eieren passen in {dozijn} dozen van {DOOS_GROOTTE}. Je houdt {rest } eieren over.");
        }
    }
}
