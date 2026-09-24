
Console.Write("Ange din epost: ");
string epost = Console.ReadLine();

Console.WriteLine(ÄrGiltigEpost(epost));

Console.WriteLine("\n\nTryck på valfri knapp för att stänga konsolen...");
Console.ReadKey();







static bool ÄrGiltigEpost(string epost)
{
    return epost.Contains("@") &&
    epost.Contains(".") &&
    epost.Length >= 5;

}