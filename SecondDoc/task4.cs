/*

Task 4: Multiplication Table
Task: Ask the user for a number N and print its multiplication table up to 10 using a loop.

*/

using System;

class Program {
    static void Main(string[] args) {
        int num = 0;
        Console.WriteLine("enter a number");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; ++i) {
            Console.WriteLine($"{i} * {num} = {i * num}");
        }
    }
}
