System.Console.WriteLine("Tot en met welke getal?");
int invoer = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Geen invoer ontvangen."));


//Deel 1
/*for( int tafels = 1;  tafels <= invoer; tafels++)
{
    for(int vermenigvuldiging = 1; vermenigvuldiging <= invoer; vermenigvuldiging++)
    {
        System.Console.WriteLine($"{tafels} x {vermenigvuldiging} = {tafels* vermenigvuldiging}");
    }
}*/

//Deel 2
for( int tafels = 1;  tafels <= invoer; tafels++)
{
    for(int vermenigvuldiging = 1; vermenigvuldiging <= invoer; vermenigvuldiging++)
    {
        System.Console.Write($"{tafels} x {vermenigvuldiging} = {tafels* vermenigvuldiging}");
    }
}