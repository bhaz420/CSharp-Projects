using System;

class MathOperation
{
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (e.g., multiplication)
        int result = firstNumber * 2; // You can change this operation as needed

        // Display the second integer to the screen
        Console.WriteLine($"Result of the math operation on {firstNumber}: {result}");
        Console.WriteLine($"Second integer: {secondNumber}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the MathOperation class
        MathOperation mathOperation = new MathOperation();

        // Call the PerformOperation method with two integers
        int firstInteger = 5;
        int secondInteger = 10;

        mathOperation.PerformOperation(firstInteger, secondInteger);

        // Instantiate the MathOperation class
        _ = new MathOperation();

        // Call the PerformOperation method with named parameters
        mathOperation.PerformOperation(firstNumber: 5, secondNumber: 10);

        // Keep the console window open
        Console.ReadLine();

    }
}
