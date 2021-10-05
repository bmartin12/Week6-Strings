using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";
            string partToLookFor = "hello";
            bool isThere;

            isThere = helloworld.ToLower().Contains(partToLookFor);

            if (isThere)
            {
                Console.WriteLine($"Leidsin {partToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"ei leidnud {partToLookFor}");
            }
        }
    }
}
