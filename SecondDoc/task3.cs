/*

Task 3: Sum of Digits
Task: Compute the sum of all digits of a given number using a loop (e.g., 456 → 4 + 5 + 6 = 15).

*/

using System;

class Program {
    static void Main(string[] args) {
        int input = 0;
        Console.WriteLine("enter an integer");
        input = int.Parse(Console.ReadLine());
        int sum = 0;
        while (input != 0) {
            sum += input % 10;
            input /= 10;
        }

        Console.WriteLine("the sum of digits is {0}", sum);
    }
}


