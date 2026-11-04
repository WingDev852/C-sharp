namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1 = 'A';
            char letter2 = 'B';

            Console.WriteLine('A' + 'B'); //131
            Console.WriteLine("A" + "B"); //AB
            Console.WriteLine('1' + 1);   //50
            Console.WriteLine('a' - 'A');//32
            Console.WriteLine("1" + 1 + 1);//111
            Console.WriteLine(1 + 1 + "1");//21
            Console.WriteLine($"{letter1}{letter2}");//AB
        }
    }
}
