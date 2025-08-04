# DCIT318 Assignment 1 - C# Console Applications

A collection of three C# console applications demonstrating various programming concepts including input validation, mathematical calculations, and user interaction.

## Project Overview

This repository contains three independent C# console applications, each designed to solve specific problems with robust input validation and user-friendly interfaces.

## Applications

### 1. [Grade Calculator](./GradeCalculator/)

**Location**: [`GradeCalculator/`](./GradeCalculator/)

A program that converts numerical grades to letter grades based on a standard grading scale.

**Features**:

- Converts numerical grades (0-100) to letter grades (A, B, C, D, F)
- Batch processing for multiple grades
- Input validation for whole numbers only
- Exit functionality with "exit" command

**Grading Scale**:

- 90 and above: A
- 80-89: B
- 70-79: C
- 60-69: D
- Below 60: F

### 2. [Movie Theater Ticket Price Calculator](./TicketPriceCalculator/)

**Location**: [`TicketPriceCalculator/`](./TicketPriceCalculator/)

A program that calculates movie ticket prices based on customer age with automatic discount application.

**Features**:

- Age-based pricing with automatic discount application
- Input validation for positive whole numbers
- Triangle validity check using Triangle Inequality Theorem
- Exit functionality with "exit" command

**Pricing Structure**:

- Regular Price: GHC 10.00 (ages 13-64)
- Discounted Price: GHC 7.00 (children 12 & under, seniors 65+)

### 3. [Triangle Type Calculator](./TriangleTypeIdentifier/)

**Location**: [`TriangleTypeIdentifier/`](./TriangleTypeIdentifier/)

A program that determines the type of triangle based on the lengths of its three sides.

**Features**:

- Triangle type detection (Equilateral, Isosceles, Scalene)
- Input validation for positive numbers
- Triangle validity check using Triangle Inequality Theorem
- Exit functionality with "exit" command

**Triangle Types**:

- **Equilateral**: All three sides are equal
- **Isosceles**: Two sides are equal
- **Scalene**: No sides are equal

## Technologies Used

- **Language**: C# (.NET 8.0)
- **Type**: Console Applications
- **Framework**: .NET Core
- **IDE**: Compatible with Visual Studio, VS Code, or any .NET IDE

## Prerequisites

Before running any of these applications, ensure you have:

- .NET 8.0 SDK or later installed on your system
- [Download .NET SDK](https://dotnet.microsoft.com/download)

## How to Run

### Option 1: Run Individual Applications

Each application can be run independently:

```bash
# Grade Calculator
cd [GradeCalculator](./GradeCalculator/)
dotnet run

# Ticket Price Calculator
cd [TicketPriceCalculator](./TicketPriceCalculator/)
dotnet run

# Triangle Type Calculator
cd [TriangleTypeIdentifier](./TriangleTypeIdentifier/)
dotnet run
```

### Option 2: Build All Applications

```bash
# Build all projects
dotnet build [GradeCalculator](./GradeCalculator/)
dotnet build [TicketPriceCalculator](./TicketPriceCalculator/)
dotnet build [TriangleTypeIdentifier](./TriangleTypeIdentifier/)
```

## Usage Examples

### Grade Calculator

```
Grade Converter

How many grades do you want to enter? 3
Enter numerical grade #1 (0-100): 85
Numerical Grade: 85
Letter Grade: B

Enter numerical grade #2 (0-100): 92
Numerical Grade: 92
Letter Grade: A

Enter numerical grade #3 (0-100): 55
Numerical Grade: 55
Letter Grade: F
```

### Ticket Price Calculator

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
```

### Triangle Type Calculator

```
Triangle Type Calculator
Enter the lengths of three sides to determine triangle type (in centimeters)
Type 'exit' to quit the application

Enter the length of side 1: 5
Enter the length of side 2: 5
Enter the length of side 3: 5

Triangle Information
Side 1: 5
Side 2: 5
Side 3: 5
Triangle Type: Equilateral
Description: All three sides are equal
```

## Common Features Across All Applications

### Input Validation

- ✅ Robust error handling for invalid inputs
- ✅ Clear error messages with retry options
- ✅ Type-specific validation (whole numbers, positive numbers, etc.)

### User Experience

- ✅ Exit functionality with "exit" command
- ✅ Multiple calculations in single session
- ✅ User-friendly prompts and messages
- ✅ Graceful error handling

### Code Quality

- ✅ Well-structured C# code with proper namespaces
- ✅ Comprehensive documentation
- ✅ Modular design with separate methods for different functionalities
- ✅ Exception handling with try-catch blocks

## Project Structure

```
dcit318-assignment1-11011482/
├── [GradeCalculator/](./GradeCalculator/)
│   ├── GradeProgram.cs
│   ├── GradeConverter.csproj
│   └── README.md
├── [TicketPriceCalculator/](./TicketPriceCalculator/)
│   ├── TicketPriceCalculator.cs
│   ├── TicketPriceCalculator.csproj
│   └── README.md
├── [TriangleTypeIdentifier/](./TriangleTypeIdentifier/)
│   ├── TriangleTypeCalculator.cs
│   ├── TriangleTypeCalculator.csproj
│   └── README.md
└── README.md (this file)
```

## Mathematical Concepts

### Triangle Inequality Theorem

Used in the Triangle Type Calculator to validate triangle formation:

- a + b > c
- a + c > b
- b + c > a

### Grade Conversion Logic

Standard academic grading scale implementation with clear boundaries.

### Age-based Pricing

Conditional logic for applying discounts based on customer age categories.

## Learning Objectives

This project demonstrates:

1. **Input Validation**: Proper handling of user input with error checking
2. **Mathematical Calculations**: Implementation of geometric and arithmetic operations
3. **Conditional Logic**: Complex decision-making based on multiple criteria
4. **User Interface Design**: Creating intuitive console applications
5. **Error Handling**: Robust exception handling and user feedback
6. **Code Organization**: Modular design with separate methods and classes

## Contributing

Feel free to submit issues or enhancement requests for any of the applications in this project.

*This project serves as Assignment 1 for the DCIT318 Programming 2 course, demonstrating proficiency in C# console application development with focus on input validation, mathematical operations, and user interaction.*
