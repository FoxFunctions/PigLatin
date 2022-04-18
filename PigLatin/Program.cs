using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static bool runAgain = true;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            while (runAgain)
            { 
                Console.WriteLine();
                Console.WriteLine("Please enter a word or phrase that you would like me to translate.");
                Console.WriteLine();
                string userInput = Console.ReadLine().ToLower();
                Console.WriteLine();
                string[] userStringArray = userInput.Split(" ");

               for (int i = 0; i < userStringArray.Length ; i++)
                {
                   char [] userCharArray = userStringArray[i].ToCharArray();

                    if (userCharArray[0] == 'a' || userCharArray[0] == 'e'|| userCharArray[0] == 'i'|| userCharArray[0] == 'o' || userCharArray[0] == 'u')
                    {
                      Console.Write(userStringArray[i] + "way ");
                    }
                    else
                    {
                      Console.Write(PigLatin(userStringArray[i]));
                    }
                }
                    runAgain = RunAgain();
            }
        }
       
        public static string PigLatin(string word)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            int firstVowelIndex = word.IndexOfAny(vowels);
            if (firstVowelIndex == -1)
            {
                return word + " ";
            }
            else
            {
                string pigLatin = word.Remove(0, firstVowelIndex) + word.Substring(0, firstVowelIndex) + "ay ";
                return pigLatin;
            }
        }

        public static bool RunAgain()
        {
            Console.WriteLine();
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
