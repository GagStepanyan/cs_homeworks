/*

   Task 7: Number Pyramid
Task: Print a number pyramid using nested loops, like:

*/

using System;

class Program {
    static void Main(string[] args) {
        int count;
        Console.WriteLine("enter a number");
        count = int.Parse(Console.ReadLine());
        if (count <= 0) {
            Console.WriteLine("invalid input");
            return;
        }
            Console.Write("\n");

        for (int i = 1; i <= count; ++i) {
            for (int j = 0; j < i; ++j) {
                Console.Write($"{i}");
            }
            Console.Write("\n");
        }
    }
}
