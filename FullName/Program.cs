using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("palun sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("palun sisesta oma perekonna nimi");
            string userLastName = Console.ReadLine();
            if (userFirstName.Length < userLastName.Length)
            {
                Console.WriteLine($"Sinu perekonna nimi on pikem kui sinu eesnimi.");
            }
            else if (userFirstName.Length > userLastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui sinu eesnimi");
            }
            else
            {
                Console.WriteLine("sama pikad.");

            }
        }
    }
}
