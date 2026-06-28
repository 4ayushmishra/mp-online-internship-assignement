using System;
using System.Collections.Generic;

namespace FizzBuzzPrimeAndAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowNumbers();

            Console.WriteLine();

            ShowAnagrams();
        }

        static void ShowNumbers()
        {
            Console.WriteLine("Number Pattern");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("3-5");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("3");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("5");
                }
                else if (CheckPrime(i))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void ShowAnagrams()
        {
            List<string> words = new List<string>()
            {
                "eat", "tea", "tan", "ate", "nat", "bat"
            };

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Sort(letters);

                string key = new string(letters);

                if (!data.ContainsKey(key))
                {
                    data[key] = new List<string>();
                }

                data[key].Add(word);
            }

            Console.WriteLine("\nAnagram Groups");

            int count = 1;

            foreach (var item in data)
            {
                Console.WriteLine("Group " + count + " : " + string.Join(", ", item.Value));
                count++;
            }
        }
    }
}
