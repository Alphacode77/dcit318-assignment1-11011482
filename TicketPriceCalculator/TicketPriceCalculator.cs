using System;

namespace MovieTheaterTicketing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Movie Theater Ticket Price Calculator");
            Console.WriteLine("Regular ticket price: GHC10");
            Console.WriteLine("Discounted price (Children 12 & under, Seniors 65+): GHC7");
            Console.WriteLine("Type 'exit' to quit the application");
            Console.WriteLine();

            while (true)
            {
                try
                {
                    // Prompt user for age
                    Console.Write("Please enter your age: ");
                    string? input = Console.ReadLine();

                    // Check for exit command
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a valid age or type 'exit' to quit.");
                        continue;
                    }

                    if (input.ToLower() == "exit")
                    {
                        Console.WriteLine("Thank you for using the Ticket Price Calculator.Enjoy your day!");
                        break;
                    }

                    // Validate and parse the input
                    if (int.TryParse(input, out int age))
                    {
                        // Check if age is valid (non-negative)
                        if (age < 0)
                        {
                            Console.WriteLine("Error: Age cannot be negative. Please enter a valid age.");
                            continue;
                        }

                        // Calculate ticket price based on age
                        decimal ticketPrice = CalculateTicketPrice(age);
                        
                        // Display the result
                        DisplayTicketPrice(age, ticketPrice);
                        
                        // Ask if user wants to calculate another ticket
                        Console.WriteLine();
                        Console.Write("Would you like to calculate another ticket? (y/n): ");
                        string? continueInput = Console.ReadLine();
                        
                        if (string.IsNullOrWhiteSpace(continueInput) || 
                            continueInput.ToLower() != "y" && continueInput.ToLower() != "yes")
                        {
                            Console.WriteLine("Thank you for using the Ticket Price Calculator. Enjoy your day!");
                            break;
                        }
                        
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid whole number for age (no decimals).");
                    }
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

        static decimal CalculateTicketPrice(int age)
        {
            const decimal REGULAR_PRICE = 10.00m;
            const decimal DISCOUNTED_PRICE = 7.00m;

            // Check if customer qualifies for discount
            if (age <= 12 || age >= 65)
            {
                return DISCOUNTED_PRICE;
            }
            else
            {
                return REGULAR_PRICE;
            }
        }

        static void DisplayTicketPrice(int age, decimal price)
        {
            Console.WriteLine();
            Console.WriteLine("Ticket Information");
            Console.WriteLine($"Age: {age}");
            
            // Determine and display customer category
            string category;
            if (age <= 12)
            {
                category = "Child";
            }
            else if (age >= 65)
            {
                category = "Senior Citizen";
            }
            else
            {
                category = "Regular";
            }
            
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Ticket Price: GHC{price:F2}");
            
            // Display discount information if applicable
            if (price == 7.00m)
            {
                Console.WriteLine("✓ Discount Applied: GHC3.00 savings!");
            }
        }
    }
}