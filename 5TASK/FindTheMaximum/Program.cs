/*

    Find the maximum from the numbers
Task: Write a program to find max from input numbers array:
1. Write a method to find the maximum value from an array of input numbers.
2. Use ref and params in method parameters.
3. Read numbers from user input.

*/
using System;

class Program {

    public static void FindMaxNum(ref int maxNum, params int[] args) {
        if (args == null || args.Length == 0) {
            Console.WriteLine("Invalid Arguments");
            return;
        }

        int max = args[0];

        foreach (int i in args) {
            if (i > max) {
                max = i;
            }
        }

        maxNum = max;
        Console.WriteLine("The Maximum Element is: " + max);

        return;
    }
    static void Main(string[] args) {
        Console.Write("How many numbers to allocate?: ");
        int size = Convert.ToInt32(Console.ReadLine());
        if (size <= 0) {
            Console.WriteLine("invalid argument");
            return;
        }
        int[] arr = new int[size];

        Console.WriteLine($"Enter {size} integers");
        for (int i = 0; i < arr.Length; ++i) {
             Console.Write($"{i + 1}) Element: ");
             while (int.TryParse(Console.ReadLine(), out arr[i]) == false) {
               Console.WriteLine("You enter invalid number for array try again"); 
            }
        }

        int maxNum = 0;
        FindMaxNum(ref maxNum, arr);
    }
}