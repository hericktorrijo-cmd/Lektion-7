int kelvin = LäsHeltal("Ange temperatur i Kelvin:", 0, 400);

int celsius = kelvin - 273;

Console.WriteLine($"Temperaturen är {celsius}°C");

Console.WriteLine("\n\nTryck på valfri tangent för att stänga konsolen...");
Console.ReadKey();

static int LäsHeltal(string ledtext, int min, int max)
{
    int tal;

    Console.Write(ledtext + " ");

    while (!int.TryParse(Console.ReadLine(), out tal) || tal < min || tal > max)
    {
        Console.WriteLine($"Fel! Ange ett tal mellan {min} och {max}.");
        Console.Write(ledtext + " ");
    }

    return tal;
}