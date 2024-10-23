using KamenNuzkyPapir;
using static KamenNuzkyPapir.Class1;

string[] volba = { "1", "2", "3" };
Hra hra = new Hra();

Console.WriteLine("Hra kámen, nůžky, papír");
Console.WriteLine("-------------------------");

while (hra.SkoreHrac < 5 && hra.SkoreNepritele < 5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Skóre - Hráč: " + hra.SkoreHrac + " | Počítač: " + hra.SkoreNepritele);
    Console.WriteLine("-------------------------");


    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("kolo hráče");
    Console.WriteLine("1-kámen");
    Console.WriteLine("2-nůžky");
    Console.WriteLine("3-papír");
    Console.WriteLine("----------------------------------");
    string zadanaHodnota = Console.ReadLine().ToLower();
    int x = Convert.ToInt32(zadanaHodnota);
    Console.Clear();

    if (x > 3)
    {
        Console.WriteLine("Neplatný výběr.");
        continue;
    }

    Random random = new Random();
    int volbaProtiHraceIndex = random.Next(volba.Length);
    string PC = volba[volbaProtiHraceIndex];


    Console.WriteLine("Počítač vybral: " + PC);
    Console.WriteLine("Vybral jsi: " + zadanaHodnota);
    Console.WriteLine("------------------------------------");


    if (zadanaHodnota == PC)
    {
        Console.WriteLine("Remíza!");
    }
    else if (
        (zadanaHodnota == "1" && PC == "2") ||
        (zadanaHodnota == "2" && PC == "3") ||
        (zadanaHodnota == "3" && PC == "1")
        )
    {
        Console.WriteLine("Výhral jsi!");
        hra.SkoreHrac++;
    }
    else
    {
        Console.WriteLine("Protivník vyhrál!");
        hra.SkoreNepritele++;
    }
    Console.WriteLine("-----------------");


}

Console.ForegroundColor = ConsoleColor.Gray;
if (hra.SkoreHrac == 5)
{
    Console.WriteLine("Výhra!");
}
else
{
    Console.WriteLine("Prohra!");
}