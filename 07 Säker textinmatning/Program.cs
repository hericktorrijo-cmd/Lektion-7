string namn = LäsSäkerText("Vad är ditt namn: ");
Console.WriteLine($"Hej {namn}, ha en trevlig eftermiddag!");


Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();


static string LäsSäkerText(string ledText)
{
    while(true)
    {
        Console.Write(ledText);
        string text = Console.ReadLine();

        if(!string.IsNullOrWhiteSpace(text))
        {
            return text;
        }

        else
        {
            Console.WriteLine("Felaktig inmatning, försök igen.");
        }
    }
}