# Grade Converter

This is a simple C# console application that converts numerical grades (0-100) into letter grades (A, B, C, D, F).

## How to Use

1. **Build and Run the Program**
   - Open the project folder in Visual Studio Code.
   - Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
   - Open a terminal in the project directory.
   - Run:

     ```
     dotnet run
     ```

2. **Follow the Prompts**
   - Enter how many grades you want to input.
   - For each grade, enter a number between 0 and 100.
   - The program will display the corresponding letter grade.
   - You can type `exit` at any prompt to quit early.

## Example

```
Grade Converter

How many grades do you want to enter? 3
Enter numerical grade #1 (0-100): 85
Numerical Grade: 85
Letter Grade: B

Enter numerical grade #2 (0-100): 72
Numerical Grade: 72
Letter Grade: C

Enter numerical grade #3 (0-100): exit
Goodbye!
```

## Notes

- Only valid numbers between 0 and 100 are accepted.
- Invalid input will prompt you to try again.
- Typing `exit` will end the program
