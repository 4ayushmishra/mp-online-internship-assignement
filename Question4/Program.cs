using System;
using System.Collections.Generic;

namespace AnagramAndGuessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAnagrams();

            Console.WriteLine();

            GuessNumber();
        }

        static void ShowAnagrams()
        {
            List<string> words = new List<string>()
            {
                "eat","tea","tan","ate","nat","bat"
            };

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Sort(letters);

                string key = new string(letters);

                if (!result.ContainsKey(key))
                {
                    result[key] = new List<string>();
                }

                result[key].Add(word);
            }

            Console.WriteLine("Anagram Groups");

            int count = 1;

            foreach (var item in result)
            {
                Console.WriteLine("Group " + count + " : " + string.Join(", ", item.Value));
                count++;
            }
        }

        static void GuessNumber()
        {
            Random random = new Random();

            int number = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("\nGuess a number between 1 and 100");

            while (guess != number)
            {
                Console.Write("Enter Guess: ");

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                attempts++;

                if (guess < number)
                {
                    Console.WriteLine("Too Low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed it in " + attempts + " attempts.");
                }
            }
        }
    }
}
