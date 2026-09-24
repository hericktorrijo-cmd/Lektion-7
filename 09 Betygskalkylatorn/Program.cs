
Console.Write("Hur mycket poäng fick du: ");
if(int.TryParse(Console.ReadLine(), out int poäng))
{
    Console.WriteLine(FastställBetyg(poäng));
}
else
{
    Console.WriteLine("Felaktig inmatning");
}


Console.WriteLine("\n\nTryck på valfri knapp för att stänga konsolen...");
Console.ReadKey();



static string FastställBetyg(int poäng)
{
    if (poäng < 50)
    return "IG";

    if (poäng < 80)
        return "G";

    
        return "VG";

}