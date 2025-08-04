using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Converter");
            Console.WriteLine();

            Console.Write("How many grades do you want to enter? ");
            int attempts = 0;
            while (!int.TryParse(Console.ReadLine(), out attempts) || attempts <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                Console.Write("How many grades do you want to enter? ");
            }

            for (int i = 0; i < attempts; i++)
            {
                Console.Write($"Enter numerical grade #{i + 1} (0-100): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid grade.");
                    i--; // repeat this attempt
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (double.TryParse(input, out double grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        string letterGrade = ConvertToLetterGrade(grade);
                        Console.WriteLine($"Numerical Grade: {grade}");
                        Console.WriteLine($"Letter Grade: {letterGrade}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Grade must be between 0 and 100.");
                        Console.WriteLine();
                        i--; // repeat this attempt
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine();
                    i--; // repeat this attempt
                }
            }
        }

        static string ConvertToLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
}