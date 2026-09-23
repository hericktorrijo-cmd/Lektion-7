HälsaAnvändare("Herick");

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();

static void HälsaAnvändare(string name)
{
    Console.WriteLine($"Hej {name}, hoppas du har en fantastisk dag på distansutbilningen!");
}