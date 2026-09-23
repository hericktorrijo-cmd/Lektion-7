GeKlädråd(10);

Console.WriteLine("\n\nTryck på valfri knapp för att stänga konsolen...");
Console.ReadKey();

static void GeKlädråd(double temperatur)
{
    if (temperatur < 10)
    {
        Console.WriteLine("Ta på dig en tjock jacka!");
    }
    else
    {
        Console.WriteLine("En tröja räcker gott!");
    }
}