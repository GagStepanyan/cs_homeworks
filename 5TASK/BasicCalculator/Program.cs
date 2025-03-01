/*

Basic Calculator
    Task: Write a program with methods for basic math operations:
    1. Add(int a, int b), Subtract(int a, int b), Multiply(int a, int b), Divide(int a, int b)
    2. Read 2 numbers from user input, read operation code and then display the result.
    3. Close the program if received X from the user.
    4. Use recursion to make the calculator run until it gets the X.

*/
using System;

class Program {

    public static int Add(int num1, int num2) {
        return num1 + num2;
    }

    public static int Sub(int num1, int num2) {
        return num1 - num2;
    }

    public static int Mul(int num1, int num2) {
        return num1 * num2;
    }

    public static double Div(int num1, int num2) {
        return num1 / num2;
    }

    public static void Main(String[] args) {
        Console.WriteLine("Welcome to Calculator");
        Calculate();
        Console.WriteLine("Finishing the work");
    }

    public static void Calculate() {
        Console.WriteLine("Enter the first number ('X' to exit)");
        string input1 = Console.ReadLine();
        if (input1 == "x" || input1 == "X") {
            return;
        }
        foreach(char c in input1) {
            if (!char.IsDigit(c)) {
                return;
            }
        }

        int num1 = int.Parse(input1);

        Console.WriteLine("Enter the second number ('X' to exit)");
        string input2 = Console.ReadLine();
        if (input2 == "x" || input2 == "X") {
            return;
        }
        foreach(char c in input2) {
            if (!char.IsDigit(c)) {
                return;
            }
        }

        int num2 = int.Parse(input2);

        Console.WriteLine("Enter the operation '+' '-' '/' '*'");
        string operation = Console.ReadLine();
        if (operation == "x" || operation == "X") {
            return;
        }

        double result = 0;

        switch (operation) 
        {
            case "+":
                result = Add(num1, num2);
                break;

            case "-":
                result = Sub(num1, num2);
                break;
            case "*":
                result = Mul(num1, num2);
                break;
            case "/":
                result = Div(num1, num2);
                break;
            default:
                Console.WriteLine("invalid operation");
                Calculate();
                return;
        }   

        Console.WriteLine($"Result: {result}");
        Calculate();
    }

}
