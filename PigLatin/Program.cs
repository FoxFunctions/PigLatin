using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator");
            Console.WriteLine();
            Console.WriteLine("Please enter a word that you would like me to translate.");
            string userInput = Console.ReadLine().ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };        
            int firstVowel = userInput.IndexOfAny(vowels);
            string pigLatin = userInput.Remove(0,firstVowel) + userInput.Substring(0,firstVowel) + "ay";

            if (userInput.StartsWith("a") || userInput.StartsWith("e") || userInput.StartsWith("i") || userInput.StartsWith("o") || userInput.StartsWith("u"))
            {
                Console.WriteLine(userInput + "way");
            }
            else
            {
                Console.WriteLine(pigLatin);
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