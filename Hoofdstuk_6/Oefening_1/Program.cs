System.Console.WriteLine("Tot en met welke getal?");
int invoer = int.Parse(Console.ReadLine());

Console.WriteLine("Hello, World!");
for( int tafels = 1;  tafels <= invoer; tafels++)
{
    for(int vermenigvuldiging = 1; vermenigvuldiging <= invoer; vermenigvuldiging++)
    {
        System.Console.WriteLine($"{tafels} x {vermenigvuldiging} = {tafels* vermenigvuldiging}");
    }
}
