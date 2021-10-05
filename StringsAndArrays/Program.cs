using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi;
            //program kuvab kasutaja eesnime pikkust

            Console.WriteLine("palun sisesta oma eesnimi");
            string userFirstname = Console.ReadLine();

            Console.WriteLine($"sinu nimi on {userFirstname.Length} sümbolit pikk.");
        }
    }
}
