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






/* What will the application do?
1 Point: The application prompts the user for a word.
1 Point: The application translates the text to Pig Latin and displays it on the console.
1 Point: The application asks the user if he or she wants to translate another word.

Build Specifications:
1 Point: Convert each word to a lowercase before translating.
1 Point: If a word starts with a vowel, just add “way” onto the ending.
2 Point: if a word starts with a consonant, move all of the consonants that appear before the first vowel to the end of the word, then add “ay” to the end of the word. 

Additional Requirements:
1 Point: For answering Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method).

Extended Exercises (2 points maximum):
1 Point: Keep the case of the word, whether its uppercase (WORD), title case (Word), or lowercase (word).
1 Point: Allow punctuation in the input string.
1 Point: Translate words with contractions. Ex: can’t become an’tcay
1 Point: Don’t translate words that have numbers or symbols. Ex: 189 should be left as 189 and hello@grandcircus.co should be left as hello@grandcircus.co.
1 Point: Check that the user has actually entered text before translating.
1 Point: Make the application take a line instead of a single word, and then find the Pig Latin for each word in the line.

Hints:
Treat “y” as a consonant. */
