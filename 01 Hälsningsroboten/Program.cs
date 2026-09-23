VisaHälsning();

Console.WriteLine("\n\nTryck på valfri knapp för att stänga konsolen...");
Console.ReadKey();

static void VisaHälsning()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Välkomen till systemet! Robot aktvierad.");
}