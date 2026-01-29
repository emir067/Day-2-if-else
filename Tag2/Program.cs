using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bitte wähle ein Programm:"); // start bildschirm
            Console.WriteLine("1 - Logik Rechner");
            Console.WriteLine("2 - Einfacher rechner");
            Console.WriteLine("0 - Beenden");

            string eingabe = Console.ReadLine();

            if (eingabe == "1") // Programm 1: Logik Rechner
            {
                Console.WriteLine("\nMini Logik Rechner");

                int zahl;
                while (true)
                {
                    Console.WriteLine("Bitte gib eine Zahl ein:");

                    if (int.TryParse(Console.ReadLine(), out zahl))
                        break;

                    Console.WriteLine("❌ Keine gültige Zahl! Bitte erneut eingeben.\n");
                }

                if (zahl < 0)
                    Console.WriteLine("Negative Zahl\n");
                else if (zahl > 0)
                    Console.WriteLine("Positive Zahl\n");
                else
                    Console.WriteLine("Die Zahl ist 0\n");
            }
            else if (eingabe == "2") // 2 Programm einfacher rechner
            {
                Console.WriteLine("\nEinfacher Rechner");

                double zahl1;
                while (true)
                {
                    Console.WriteLine("Gib die erste Zahl ein:");
                    if (double.TryParse(Console.ReadLine(), out zahl1))
                        break;

                    Console.WriteLine("❌ Ungültige Zahl! Bitte erneut eingeben.\n");
                }

                double zahl2;
                while (true)
                {
                    Console.WriteLine("Gib die zweite Zahl ein:");
                    if (double.TryParse(Console.ReadLine(), out zahl2))
                        break;

                    Console.WriteLine("❌ Ungültige Zahl! Bitte erneut eingeben.\n");
                }

                string operation;
                while (true)
                {
                    Console.WriteLine("Wähle eine Operation (+, -, *, /):");
                    operation = Console.ReadLine();

                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                        break;

                    Console.WriteLine("❌ Ungültige Operation! Bitte erneut eingeben.\n");
                }

                if (operation == "/" && zahl2 == 0)
                {
                    Console.WriteLine("❌ Division durch 0 ist nicht erlaubt!\n");
                }
                else
                {
                    double ergebnis = operation switch
                    {
                        "+" => zahl1 + zahl2,
                        "-" => zahl1 - zahl2,
                        "*" => zahl1 * zahl2,
                        "/" => zahl1 / zahl2
                    };

                    Console.WriteLine($"Das Ergebnis ist: {ergebnis}\n");
                }
            }
            else if (eingabe == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl!\n");
                continue;
            }
        }
    }
}