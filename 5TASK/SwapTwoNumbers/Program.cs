/*
    Swap Two Numbers
Task: Write a program to swap 2 numbers:
1. Write a method to swap the values of two integers.
2. Use ref in method parameters.
3. Read 2 numbers from user input and validate the input values.
*/

using System;

class Program {

    static void Swap(ref int num1, ref int num2) {
        int tmp = num1;
        num1 = num2;
        num2 = tmp;
    }
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Another one: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Swap(ref num1, ref num2);
        Console.WriteLine($"NUM1 after swap: {num1}");
        Console.WriteLine($"NUM2 after swap: {num2}");
    }
}