LoggaMeddelande("Jag heter HERICK!", "NAMN");
LoggaMeddelande("Jag heter HERICK!");

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();



static void LoggaMeddelande(string meddelande, string loggTyp = "INFO")
{
    Console.WriteLine($"[{loggTyp}] - {meddelande}"); 
}