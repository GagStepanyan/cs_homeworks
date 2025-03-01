/*

Task 8: Fibonacci Sequence
Task: Write a program that returns n-th number from Fibonacci Sequence:
1. Write a recursive method that returns the n-th number in Fibonacci Sequence.
3. Call it with a user-provided n.

*/

using System;
class Program {

    public static int Fibonacci(int num) {
        if (num <= 1) {
            return num;
        }
        return Fibonacci(num - 1) + Fibonacci(num - 2);
    }
    public static void Main() {
        Console.Write("Enter Fibonacci Sequence's index: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"In [{num}] index there is: {Fibonacci(num)}");
    }    
}