using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Küsime nime
            // Salvestame nime massiivi Char tüüpi
            //Array.reverse
            //teeme uus String, et saaks esialgse nime võrrelda Reverse nimega.
            string name;
            Console.WriteLine("Please enter a name: ");
            name = Console.ReadLine();

            char[] temp = name.ToCharArray();
            Array.Reverse(temp);
            string nameReverse = new string(temp);

            if (name.ToLower() == nameReverse.ToLower())
            {
                Console.WriteLine("It is a Palindrome.");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome.");
            }

            Console.ReadLine();
        }
        
    }
}
