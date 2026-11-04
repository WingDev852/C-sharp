namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personage1 = "Alice";
            string personage2 = "Bob";

            string dialoog = $@"{personage1}: Hoe gaat het met je? 

";

            Console.WriteLine(dialoog);

            Console.WriteLine($"{personage1}: Hoe gaat het met je? \n \t {personage2}: Goed, dank je! Hoe gaat het met jou? \n {personage1}: Ook goed, bedankt dat je het vraagt." );

           
        }
    }
}
