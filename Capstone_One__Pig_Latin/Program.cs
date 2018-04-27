using System;

namespace Capstone_One__Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Pig Latin Translator!");

            while (true)
            {
                Console.Write("Enter a word to be translated into Pig Latin: ");
                string word = Console.ReadLine();

                string vowels = "aeiouAEIOU";

                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (word[i] == vowels[j])
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(word + "way");
                                i = word.Length;
                                j = vowels.Length;
                            }
                            else if(i > 0)
                            {
                                string newWord = word.Substring(i, (word.Length - i));

                                string start = word.Substring(0, i);


                                Console.WriteLine(newWord + start + "ay");

                                i = word.Length;
                                j = vowels.Length;
                            }
                        }
                    }
                }
            }
        }
    }
}
