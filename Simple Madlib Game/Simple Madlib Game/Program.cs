using System;

namespace Simple_Madlib_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Grade: ");
            string grade = Console.ReadLine();
            Console.Write("Enter your University name: ");
            string universityName = Console.ReadLine();
            Console.Write("Enter your University course name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter your Faculty school name: ");
            string facultyName = Console.ReadLine();

            Console.Write("Enter your admission date (format: dd-MM-yyyy): ");
            string admissionDateInput = Console.ReadLine();

            DateTime admissionDate;
            if (DateTime.TryParseExact(admissionDateInput, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out admissionDate))
            {
                // Clear the console screen after capturing the inputs
                Console.Clear();

                // Date parsing successful, proceed with the Mad Lib
                Console.WriteLine("My name is " + name + ". After scoring " + grade + " grade in Highschool, \n" +
                    "I was admitted at " + universityName + " on " + admissionDate.ToString("dd-MM-yyyy") + " to pursue " + courseName + "\n" +
                    " at the School of " + facultyName + ".\n");

                Console.ReadLine();
            }
            else
            {
                // Date parsing failed, inform the user and exit the program
                Console.WriteLine("Invalid date format. Please enter the date in the format 'dd-MM-yyyy HH:mm'.");
            }
        }
    }
}
