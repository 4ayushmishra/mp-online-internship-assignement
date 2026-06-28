using System;

namespace DefaultValuesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDefaultValues();

            Console.WriteLine();

            ShowNullableDemo();
        }

        static void ShowDefaultValues()
        {
            int num = default;
            bool flag = default;
            string text = default;
            DateTime date = default;

            Console.WriteLine("Default Values");
            Console.WriteLine("int : " + num);
            Console.WriteLine("bool : " + flag);
            Console.WriteLine("string : " + (text == null ? "null" : text));
            Console.WriteLine("DateTime : " + date);
        }

        static void ShowNullableDemo()
        {
            Console.WriteLine("\nNullable<int> Demo");

            int? a = null;
            int? b = 10;
            int? c = null;

            Console.WriteLine("a HasValue : " + a.HasValue);
            Console.WriteLine("b HasValue : " + b.HasValue);

            Console.WriteLine("a Default Value : " + a.GetValueOrDefault());
            Console.WriteLine("b Default Value : " + b.GetValueOrDefault());

            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a == c : " + (a == c));

            if (b.HasValue)
            {
                Console.WriteLine("Value of b : " + b.Value);
            }

            try
            {
                Console.WriteLine(a.Value);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot access a.Value because it is null.");
            }
        }
    }
}
