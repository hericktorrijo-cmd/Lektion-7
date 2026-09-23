SkrivAvskiljare();
Console.WriteLine("Skriver lite text!\n");
SkrivAvskiljare();
Console.WriteLine("Skriver lite mer text!\n");
SkrivAvskiljare();
Console.WriteLine("Skriver sista text!");

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();
static void SkrivAvskiljare()
{
    for(int i = 0; i < 30; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}