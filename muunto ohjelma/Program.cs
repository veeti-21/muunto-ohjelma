

using System;
class Program
{
    static void Main()
    {
        // Yksiköt ja niiden muuntosuhteet metreihin
        string[] units = { "Millimetri", "Senttimetri", "Metri", "Kilometri", "Tuuma", "Jalka", "Jaardi", "Maili" };
        double[] toMeters = { 0.001, 0.01, 1, 1000, 0.0254, 0.3048, 0.9144, 1609.344 };

        //kysytään yksitöt ja lukumäärät
        Console.WriteLine("Valitse lähtöyksikkö:");
        for (int i = 0; i < units.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {units[i]}");
        }

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > units.Length)
        {
            Console.WriteLine("Virheellinen valinta, yritä uudelleen:");
        }

        Console.WriteLine($"Syötä arvo ({units[choice - 1]}):");
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Virheellinen numero, yritä uudelleen:");
        }

        // Muutetaan arvo metreiksi
        double meters = value * toMeters[choice - 1];

        Console.WriteLine("\nMuunnetut arvot:");
        for (int i = 0; i < units.Length; i++)
        {
            double converted = meters / toMeters[i];
            Console.WriteLine($"{units[i]}: {converted:0.########}");
        }
    }
}

