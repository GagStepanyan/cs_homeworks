/*

Task 11: Check If a Number Is Positive, Negative, or Zero 
Elements: simple types, without loops

Task:
Take an integer input and.
Determine if it is positive, negative, or zero.
Example Input:
Enter the number: 10 

Output:
The number 10 is positive.

*/

using System;

 class Program {
     static void Main (string[] args) {
         Console.WriteLine ("enter an integer");
         int num = 0;
         num = int.Parse(Console.ReadLine());
         if (num > 0) {
             Console.WriteLine ("Positive");
         } else if (num < 0) {
             Console.WriteLine("Negative");
         } else {
             Console.WriteLine ("Zero");
         }

     }
 }
