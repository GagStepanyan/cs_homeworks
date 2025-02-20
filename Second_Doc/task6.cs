/*

Task 6: Collatz Conjecture
Task: Given a number N, apply the following rule until N becomes 1:
1. If N is even → N = N / 2
2. If N is odd → N = 3 * N + 1
Count how many steps it takes to reach 1.


*/

using System;

 class Program {
     static void Main(string[] args) {
         int num;
         Console.WriteLine("enter a positive number (excluding 0)");
         num = int.Parse(Console.ReadLine());

         if (num <= 0) {
             Console.WriteLine("invalid input");
             return;
         }

         int counter = 0;

         while (num != 1) {
             if (num % 2 == 0) {
                 num /= 2;
             } else {
                 num = 3 * num + 1;
             }

             ++counter;
         }

         Console.WriteLine($"it took {counter} iterations");
     }
 }
