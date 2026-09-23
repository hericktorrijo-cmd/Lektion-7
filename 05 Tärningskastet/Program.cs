Console.WriteLine($"Du slog en {KastaTärning()}");
Console.WriteLine($"Du slog en {KastaTärning()}");
Console.WriteLine($"Du slog en {KastaTärning()}");
Console.WriteLine($"Du slog en {KastaTärning()}");


Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();

static int KastaTärning()
{
    Random rnd = new Random();
    int tärning = rnd.Next(1, 7);
    
    return tärning;
}