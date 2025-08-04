using System;

namespace TriangleTypeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Type Calculator");
            Console.WriteLine("Enter the lengths of three sides to determine triangle type (in centimeters)");
            Console.WriteLine("Type 'exit' to quit the application");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    // Get first side
                    Console.Write("Enter the length of side 1: ");
                    string? input1 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input1))
                    {
                        Console.WriteLine("Please enter a valid number or type 'exit' to quit.");
                        continue;
                    }

                    if (input1.ToLower() == "exit")
                    {
                        Console.WriteLine("Thank you for using the Triangle Type Calculator. Enjoy your day!");
                        break;
                    }

                    if (!double.TryParse(input1, out double side1) || side1 <= 0)
                    {
                        Console.WriteLine("Error: Please enter a valid positive number for side 1.");
                        continue;
                    }

                    // Get second side
                    Console.Write("Enter the length of side 2: ");
                    string? input2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input2))
                    {
                        Console.WriteLine("Please enter a valid number or type 'exit' to quit.");
                        continue;
                    }

                    if (input2.ToLower() == "exit")
                    {
                        Console.WriteLine("Thank you for using the Triangle Type Calculator. Enjoy your day!");
                        break;
                    }

                    if (!double.TryParse(input2, out double side2) || side2 <= 0)
                    {
                        Console.WriteLine("Error: Please enter a valid positive number for side 2.");
                        continue;
                    }

                    // Get third side
                    Console.Write("Enter the length of side 3: ");
                    string? input3 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input3))
                    {
                        Console.WriteLine("Please enter a valid number or type 'exit' to quit.");
                        continue;
                    }

                    if (input3.ToLower() == "exit")
                    {
                        Console.WriteLine("Thank you for using the Triangle Type Calculator. Enjoy your day!");
                        break;
                    }

                    if (!double.TryParse(input3, out double side3) || side3 <= 0)
                    {
                        Console.WriteLine("Error: Please enter a valid positive number for side 3.");
                        continue;
                    }

                    // Check if the sides can form a valid triangle
                    if (!IsValidTriangle(side1, side2, side3))
                    {
                        Console.WriteLine("Error: These three sides cannot form a valid triangle.");
                        Console.WriteLine("The sum of any two sides must be greater than the third side.");
                        Console.WriteLine();
                        continue;
                    }

                    // Determine and display triangle type
                    string triangleType = DetermineTriangleType(side1, side2, side3);
                    DisplayTriangleInfo(side1, side2, side3, triangleType);

                    // Ask if user wants to calculate another triangle
                    Console.WriteLine();
                    Console.Write("Would you like to calculate another triangle? (y/n): ");
                    string? continueInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(continueInput) ||
                        continueInput.ToLower() != "y" && continueInput.ToLower() != "yes")
                    {
                        Console.WriteLine("Thank you for using the Triangle Type Calculator. Enjoy your day!");
                        break;
                    }

                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static string DetermineTriangleType(double a, double b, double c)
        {
            // Check for equilateral triangle (all sides equal)
            if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001)
            {
                return "Equilateral";
            }
            // Check for isosceles triangle (two sides equal)
            else if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
            {
                return "Isosceles";
            }
            // If no sides are equal, it's scalene
            else
            {
                return "Scalene";
            }
        }

        static void DisplayTriangleInfo(double a, double b, double c, string triangleType)
        {
            Console.WriteLine();
            Console.WriteLine("Triangle Information");
            Console.WriteLine($"Side 1: {a}");
            Console.WriteLine($"Side 2: {b}");
            Console.WriteLine($"Side 3: {c}");
            Console.WriteLine($"Triangle Type: {triangleType}");
            
            // Add description based on triangle type
            switch (triangleType)
            {
                case "Equilateral":
                    Console.WriteLine("Description: All three sides are equal");
                    break;
                case "Isosceles":
                    Console.WriteLine("Description: Two sides are equal");
                    break;
                case "Scalene":
                    Console.WriteLine("Description: No sides are equal");
                    break;
            }
        }
    }
} 