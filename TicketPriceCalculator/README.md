# Movie Theater Ticket Price Calculator

A C# console application that calculates movie theater ticket prices based on customer age with automatic discount application.

## Features

- **Age-based Pricing**: Automatically applies discounts for children and senior citizens
- **Input Validation**: Ensures only valid whole numbers are accepted for age
- **User-Friendly Interface**: Clear prompts and helpful error messages
- **Exit Functionality**: Type "exit" to quit the application at any time
- **Multiple Calculations**: Calculate ticket prices for multiple customers in one session

## Pricing Structure

- **Regular Price**: GHC 10.00 (ages 13-64)
- **Discounted Price**: GHC 7.00
  - Children (12 years and under)
  - Senior Citizens (65 years and older)

## How to Run

### Prerequisites

- .NET 8.0 SDK or later installed on your system
- [Download .NET SDK](https://dotnet.microsoft.com/download)

### Steps

1. Open a terminal/command prompt in the project directory
2. Build the project:

   ```
   dotnet build
   ```

3. Run the application:

   ```
   dotnet run
   ```

## Usage

1. **Start the Application**: Run the program using `dotnet run`
2. **Enter Age**: Type a whole number for the customer's age (0-100)
3. **View Results**: The program displays:
   - Customer's age
   - Customer category (Child, Regular, or Senior Citizen)
   - Ticket price
   - Discount information (if applicable)
4. **Continue or Exit**:
   - Choose to calculate another ticket (y/n)
   - Type "exit" at any prompt to quit

## Input Validation

The program validates user input to ensure:

- ✅ Only whole numbers (integers) are accepted
- ✅ No decimal numbers allowed
- ✅ No negative ages allowed
- ✅ Clear error messages for invalid input
- ✅ Option to retry after invalid input

## Example Output

```
Movie Theater Ticket Price Calculator
Regular ticket price: GHC10
Discounted price (Children 12 & under, Seniors 65+): GHC7
Type 'exit' to quit the application

Please enter your age: 25
Ticket Information
Age: 25
Category: Regular
Ticket Price: GHC10.00

Would you like to calculate another ticket? (y/n): y

Please enter your age: 8
Ticket Information
Age: 8
Category: Child
Ticket Price: GHC7.00
✓ Discount Applied: GHC3.00 savings!

Would you like to calculate another ticket? (y/n): n
Thank you for using the Ticket Price Calculator. Enjoy your day!

Press any key to exit...
```

## Error Handling Examples

```
Please enter your age: 25.5
Error: Please enter a valid whole number for age (no decimals).

Please enter your age: abc
Error: Please enter a valid whole number for age (no decimals).

Please enter your age: -5
Error: Age cannot be negative. Please enter a valid age.

Please enter your age: exit
Thank you for using the Ticket Price Calculator. Enjoy your day!
```

## Project Structure

- `TicketPriceCalculator.cs` - Main program file containing the ticket calculation logic
- `README.md` - This documentation file

## Key Methods

- `CalculateTicketPrice(int age)` - Determines ticket price based on age
- `DisplayTicketPrice(int age, decimal price)` - Shows ticket information and category

## Technologies Used

- **Language**: C# (.NET 8.0)
- **Type**: Console Application
- **Framework**: .NET Core

## Contributing

Feel free to submit issues or enhancement requests for this project.

