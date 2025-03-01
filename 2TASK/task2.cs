/*

Task 2: Reverse a Number
Task: Given an integer, reverse its digits using a loop (e.g., 12345 → 54321).

*/

using System;
class Program {
    static void Main(string[] args) {
        int inputNum = 0;
        int outputNum = 0;
        Console.WriteLine("enter a number: ");
        inputNum = int.Parse(Console.ReadLine());
        while (inputNum != 0) {
            int last = inputNum % 10;
            outputNum = outputNum * 10 + last;
            inputNum /= 10;
        }

        Console.WriteLine($"the reversed digit is {outputNum}");
    }
}
