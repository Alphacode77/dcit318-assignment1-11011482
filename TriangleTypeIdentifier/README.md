# Triangle Type Calculator

A C# console application that determines the type of triangle based on the lengths of its three sides.

## Features

- **Triangle Type Detection**: Automatically identifies triangle types based on side lengths
- **Input Validation**: Ensures only valid positive numbers are accepted
- **Triangle Validity Check**: Verifies that the sides can form a valid triangle using the Triangle Inequality Theorem
- **User-Friendly Interface**: Clear prompts and helpful error messages
- **Exit Functionality**: Type "exit" to quit the application at any time
- **Multiple Calculations**: Calculate triangle types for multiple sets of sides in one session

## Triangle Types

The program identifies three types of triangles:

1. **Equilateral Triangle**: All three sides are equal
   - Example: sides 5, 5, 5

2. **Isosceles Triangle**: Two sides are equal
   - Example: sides 5, 5, 3 or sides 3, 5, 5

3. **Scalene Triangle**: No sides are equal
   - Example: sides 3, 4, 5

## Triangle Validity

The program uses the **Triangle Inequality Theorem** to ensure the sides can form a valid triangle:

- The sum of any two sides must be greater than the third side
- All sides must be positive numbers

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
2. **Enter Side Lengths**: Input three positive numbers for the triangle sides
3. **View Results**: The program displays:
   - All three side lengths
   - Triangle type (Equilateral, Isosceles, or Scalene)
   - Description of the triangle type
4. **Continue or Exit**:
   - Choose to calculate another triangle (y/n)
   - Type "exit" at any prompt to quit

## Input Validation

The program validates user input to ensure:

- ✅ Only positive numbers are accepted
- ✅ No negative or zero values allowed
- ✅ Triangle validity using Triangle Inequality Theorem
- ✅ Clear error messages for invalid input
- ✅ Option to retry after invalid input

## Example Output

```
Triangle Type Calculator
=======================
Enter the lengths of three sides to determine triangle type
Type 'exit' to quit the application

Enter the length of side 1: 5
Enter the length of side 2: 5
Enter the length of side 3: 5

=== Triangle Information ===
Side 1: 5
Side 2: 5
Side 3: 5
Triangle Type: Equilateral
Description: All three sides are equal

Would you like to calculate another triangle? (y/n): y

Enter the length of side 1: 5
Enter the length of side 2: 5
Enter the length of side 3: 3

=== Triangle Information ===
Side 1: 5
Side 2: 5
Side 3: 3
Triangle Type: Isosceles
Description: Two sides are equal

Would you like to calculate another triangle? (y/n): n
Thank you for using the Triangle Type Calculator. Goodbye!

Press any key to exit...
```

## Error Handling Examples

```
Enter the length of side 1: -5
Error: Please enter a valid positive number for side 1.

Enter the length of side 1: abc
Error: Please enter a valid positive number for side 1.

Enter the length of side 1: 1
Enter the length of side 2: 2
Enter the length of side 3: 10
Error: These three sides cannot form a valid triangle.
The sum of any two sides must be greater than the third side.

Enter the length of side 1: exit
Thank you for using the Triangle Type Calculator. Goodbye!
```

## Project Structure

- `TriangleTypeCalculator.cs` - Main program file containing the triangle calculation logic
- `TriangleTypeCalculator.csproj` - Project configuration file
- `TriangleTypeCalculator_README.md` - This documentation file

## Key Methods

- `IsValidTriangle(double a, double b, double c)` - Checks if sides can form a valid triangle
- `DetermineTriangleType(double a, double b, double c)` - Identifies the triangle type
- `DisplayTriangleInfo(double a, double b, double c, string triangleType)` - Shows triangle information

## Mathematical Background

### Triangle Inequality Theorem

For a triangle with sides a, b, and c:

- a + b > c
- a + c > b  
- b + c > a

### Triangle Classification

- **Equilateral**: a = b = c
- **Isosceles**: a = b OR a = c OR b = c (but not all equal)
- **Scalene**: a ≠ b AND a ≠ c AND b ≠ c

## Technologies Used

- **Language**: C# (.NET 8.0)
- **Type**: Console Application
- **Framework**: .NET Core

## Contributing

Feel free to submit issues or enhancement requests for this project.

## License

This project is open source and available under the MIT License.
