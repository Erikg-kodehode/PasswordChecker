using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Skriv inn passordet du vil sjekke: ");
        string? passord = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(passord))
        {
            Console.WriteLine("Passordet kan ikke være tomt.");
            return;
        }

        VurderPassord(passord);
    }

    static void VurderPassord(string passord)
    {
        int lengde = passord.Length;

        if (lengde < 6)
        {
            Console.WriteLine("Svakt passord");
        }
        else if (lengde < 12)
        {
            Console.WriteLine("Middels sterkt passord");
        }
        else
        {
            Console.WriteLine("Sterkt passord");
        }

        if (ErEkstraSterkt(passord))
        {
            Console.WriteLine("Ekstra sterkt passord!");
        }
    }

    static bool ErEkstraSterkt(string passord)
    {
        bool harTall = Regex.IsMatch(passord, @"\d");
        bool harStoreBokstaver = Regex.IsMatch(passord, @"[A-Z]");
        bool harSpesialtegn = Regex.IsMatch(passord, @"[!@#$%^&*(),.?\""{}|<>]");

        return harTall && harStoreBokstaver && harSpesialtegn;
    }
}
