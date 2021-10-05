using System;

namespace SubstituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm asendab kõik 'a' tähed nimes tärniga (*)
            //programm kuvab tulemust konsoolis
            Console.WriteLine("sisesta oma eesnimi:");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();
            string fullname = $"{userFirstName}{userLastName}".ToLower();
            fullname = fullname.Replace('a', '*');
            Console.WriteLine(fullname);
        }
    }
}
