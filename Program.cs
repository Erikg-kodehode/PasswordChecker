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

        Console.WriteLine(VurderPassord(passord));
    }

    static string VurderPassord(string passord)
    {
        return ErEkstraSterkt(passord) ? "Ekstra sterkt passord!" :
               passord.Length < 8 ? "Svakt passord" :
               passord.Length < 12 ? "Middels sterkt passord" :
               "Sterkt passord";
    }

    static bool ErEkstraSterkt(string passord)
    {
        return Regex.IsMatch(passord, @"\d") || Regex.IsMatch(passord, @"[!@#$%^&*(),.?""{}|<>]");
    }
}
