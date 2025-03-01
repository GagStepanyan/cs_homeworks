/*

    Sum of Any Numbers
Task: Write a program for numbers sum calculation:
1. Write a method that calculates the sum of the numbers in an array.
2. Use params in method parameters.
3. Read numbers from user input.

*/

using System;

class Program {
    static void SumOfElements(out int sum, params int[] elements) {
        sum = 0;
        foreach(int i in elements) {
            sum += i;
        }
    }
    static void Main(string[] args) {
        Console.Write("How many numbers do you want?: ");
        int size = Convert.ToInt32(Console.ReadLine());
        if (size <= 0) {
            Console.WriteLine("Invalid argument");
            return;
        }
        int[] arr = new int[size];

        Console.WriteLine($"Enter {size} elements");
        for (int i = 0; i < arr.Length; ++i) {
            Console.Write($"{i + 1}) element: ");
             while (int.TryParse(Console.ReadLine(), out arr[i]) == false) {
               Console.WriteLine("You enter invalid number for array try again"); 
            }
        }

        int sum = 0;
        SumOfElements(out sum, arr);

        Console.WriteLine($"The Sum: {sum}");
    }
}