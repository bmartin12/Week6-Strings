using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimeja perekonnanime
            //programm kuvab , mitu 'a' tähte kasutaja eesnimes ja perekonnanimes kokku on

            // char a = 'a';

            Console.WriteLine("sisesta oma eesnime:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastname = Console.ReadLine();

            string fullName = $"{userFirstName}{userLastname}";



            /*foreach(char character in fullName)
            {
                if(character == 'a')
                {
                    counter++; //counter = counter + 1
                }
            }*/
            

            /*int counter = 0;
            int i = fullName.Length-1;

            while(i >= 0)
            {
                Console.WriteLine(fullName[i]);
                if(fullName[fullName.Length - 1] == 'a')
                {
                    counter++;
                }
                i--;
            }*/

            int counter = 0;

            for(int i = 0; 1 < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine($"sinu nimes on {counter} a-tähte");


        }
    }
}
