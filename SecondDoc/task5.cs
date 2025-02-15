/*

Task 5: Prime Number Checker
Task: Check whether a given number is prime using a loop.

*/
using System;

class Program {
    static void Main(string[] args) {
        int num = 0;
        Console.WriteLine("enter a number");
        num = int.Parse(Console.ReadLine());
        if (num <= 1) {
            Console.WriteLine($"{num} is neither prime nor composite");
            return;
        }
        bool isPrime = true;

        for (int i = 2; i <= num/2; ++i) {
            if (num % i == 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) {
            Console.WriteLine("is prime");
        } else {
            Console.WriteLine("isnt prime");
        }
    }  
}
