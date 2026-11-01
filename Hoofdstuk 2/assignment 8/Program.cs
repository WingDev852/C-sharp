namespace assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double massa = 80.6;
            const double G_AARDE = 9.81;

           const double mercurius = 0.38;
           const double venus = 0.91;
           const double aarde = 1.00;
           const double mars = 0.38;
           const double jupiter = 2.34;
           const double saturnus = 1.06;
           const double uranus = 0.92;
           const double neptunus = 1.19;
           const double pluto = 0.06;

            Console.WriteLine($"Je weegt op Mercurius {massa*G_AARDE*mercurius} N");
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * venus} N");
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * aarde} N");
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * mars} N");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * jupiter} N");
            Console.ResetColor();
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * saturnus} N");
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * uranus} N");
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * neptunus} N");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je weegt op Mercurius {massa * G_AARDE * pluto} N");
            Console.ResetColor();
        }
    }
}
