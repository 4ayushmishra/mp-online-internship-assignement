using System;
using System.Linq;

namespace PasswordDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            CheckPassword(password);

            Console.WriteLine();

            Console.Write("Enter Message: ");
            string text = Console.ReadLine();

            string encodedText = Encode(text);
            Console.WriteLine("Encoded Message : " + encodedText);

            string decodedText = Decode(encodedText);
            Console.WriteLine("Decoded Message : " + decodedText);
        }

        static void CheckPassword(string password)
        {
            bool lengthOk = password.Length == 8;
            bool upper = password.Any(char.IsUpper);
            bool digit = password.Any(char.IsDigit);

            Console.WriteLine("\nPassword Check");

            Console.WriteLine("Length 8 : " + (lengthOk ? "Yes" : "No"));
            Console.WriteLine("Capital Letter : " + (upper ? "Yes" : "No"));
            Console.WriteLine("Digit : " + (digit ? "Yes" : "No"));

            if (lengthOk && upper && digit)
                Console.WriteLine("Password is Strong");
            else
                Console.WriteLine("Password is Weak");
        }

        static string Encode(string text)
        {
            char[] data = text.Select(c => (char)(c + 2)).ToArray();

            Array.Reverse(data);

            return new string(data);
        }

        static string Decode(string text)
        {
            char[] data = text.ToCharArray();

            Array.Reverse(data);

            char[] original = data.Select(c => (char)(c - 2)).ToArray();

            return new string(original);
        }
    }
}
