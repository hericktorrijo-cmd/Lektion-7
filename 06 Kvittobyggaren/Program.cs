SkrivUtKvittoLine("Padel rack", 3599.00m);

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();

static void SkrivUtKvittoLine(string produkt, decimal pris)
{
    Console.WriteLine($"{produkt.PadRight(25, '.')}{pris, 10:C}");
}