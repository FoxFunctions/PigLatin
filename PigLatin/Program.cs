using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static bool runAgain = true;
        
        public static void Main(string[] args)
        {
            while (runAgain)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                Console.WriteLine();
                Console.WriteLine("Please enter a word that you would like me to translate.");
                string userInput = Console.ReadLine().ToLower();
                string[] c = userInput.Split(" ");

               for (int i = 0; i < c.Length ; i++)
                {
                   char [] b = c[i].ToCharArray();

                    if (b[0] == 'a' || b[0] == 'e'|| b[0] == 'i'|| b[0] == 'o' || b[0] == 'u')
                    {
                        Console.Write(c[i] + "way ");
                    }
                    else
                    {
                      Console.Write(PigLatin(c[i]));
                    }
                }
                    runAgain = RunAgain();
            }
        }
        // try a different find vowel method. y not being a vowel is causing the blowup.
        public static string PigLatin(string word)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int i = word.IndexOfAny(vowels);
            if (i == -1)
            {
                return word;
            }
            else
            {
                string pigLatin = word.Remove(0, i) + word.Substring(0, i) + "ay ";
                return pigLatin;
            }
        }

        public static bool RunAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to run the translator again? y/n");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that");
                Console.WriteLine("Please input y or n");
                Console.WriteLine("Lets try again");
                return RunAgain();
            }
        }
    }
}
