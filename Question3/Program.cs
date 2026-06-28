using System;

namespace AgeAndHoursDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HoursToDays();

            Console.WriteLine();

            CalculateAge();
        }

        static void HoursToDays()
        {
            Console.Write("Enter Hours: ");
            int hours = int.Parse(Console.ReadLine());

            int days = hours / 24;
            int extraHours = hours % 24;

            Console.WriteLine("\nHours to Days");
            Console.WriteLine(hours + " Hours = " + days + " Day(s) and " + extraHours + " Hour(s)");
        }

        static void CalculateAge()
        {
            Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;

            if (today < dob.AddYears(age))
            {
                age--;
            }

            Console.WriteLine("\nAge Details");
            Console.WriteLine("Date of Birth : " + dob.ToString("dd/MM/yyyy"));
            Console.WriteLine("Today's Date  : " + today.ToString("dd/MM/yyyy"));
            Console.WriteLine("Age : " + age + " Years");
        }
    }
}
