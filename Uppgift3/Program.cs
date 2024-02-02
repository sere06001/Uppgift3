using System;
using System.Collections.Generic;
namespace uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map["Sverige"] = "450 000km^2";
            map["Norge"] = "385 000km^2";
            map["Danmark"] = "43 000km^2";
            map["Finland"] = "338 000km^2";

            Console.WriteLine("Skriv \"Sverige\", \"Norge\", \"Danmark\" eller \"Finland\" så kommer programmet att skriva ut landets area.");
            string svar = Console.ReadLine();
            Console.WriteLine($"{svar} har en area på {map[svar]}");
            Console.ReadKey();
        }
    }
}