using System;

namespace Capstone_One__Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask if user would like to translate a word into Pig Latin
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Would you like to translate a word to Pig Latin (y/n)?");
            string option = Console.ReadLine().ToUpper();

            while (option == "Y")
                
            {   //Ask for user to input word
                Console.Write("Enter a word to be translated into Pig Latin: ");
                //Store word as string and convert to lowercase
                string word = Console.ReadLine().ToLower();

                //Declare string containing all vowels for later comparison
                string vowels = "aeiou";

                //Create for loop that repeats for each letter in the input word
                for (int i = 0; i < word.Length; i++)
                {
                    //Create for loop that repeats for each of the five vowels
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (word[i] == vowels[j])
                        {
                            //Create conditional to distinguish if input word has any vowels
                            if (i == 0)
                            {
                                //If no vowels, just add "way" to the end of the input word
                                Console.WriteLine(word + "way");

                                //Fulfill for loop variables to end loop
                                i = word.Length;
                                j = vowels.Length;

                                //Ask if user would like to translate another word, if Yes, program starts before the while loop
                                Console.WriteLine("Would you like to translate another word? (y/n)");
                                option = Console.ReadLine().ToUpper();
                            }
                            else
                            {   //Create string newWord that is the word at the first vowel and everything after
                                string newWord = word.Substring(i, (word.Length - i));

                                //Create string start that is everything in the word before the first vowel
                                string start = word.Substring(0, i);

                                //Write to the console the variables containing the correct letters in the correct order and add "ay"
                                Console.WriteLine(newWord + start + "ay");

                                //Fulfill for loop variables to end loop
                                i = word.Length;
                                j = vowels.Length;

                                //Ask if user would like to translate another word, if Yes, program starts before the while loop
                                Console.WriteLine("Would you like to translate another word? (y/n)");
                                option = Console.ReadLine().ToUpper();

                            }
                        }
                    }
                }
            }
        }
    }
}
