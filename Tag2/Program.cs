using System;

class LogikRechner
{
    static void Main()
    {
        Console.WriteLine("Mini Logik Rechner");
        Console.WriteLine("Bitte gib eine zahl ein");
        if (int.TryParse(Console.ReadLine(), out int zahl))
        {
            if (zahl < 0)
                Console.WriteLine("Negative Zahl");
            else if (zahl > 0)
                Console.WriteLine("Positive Zahl");
            else
                Console.WriteLine("Die Zahl ist 0");
        }
        else
        {
            Console.WriteLine("Keine gültige Zahl!");
        }
    }
}
