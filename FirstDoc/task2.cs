/*

Task 12: Check Leap Year
Elements: simple types, without loops

Task:
1. Take an integer input and.
2. Determine if it is a leap year.
 Hint: A year is a leap year if It is divisible by 400, or It is divisible by 4 but not by 100.


*/

 using System;
 
 class Program {
     static void Main(string[] args) {
 
         int num = 0;
         Console.WriteLine("enter a year");
         num = int.Parse(Console.ReadLine());
         if ((num % 400 == 0) || ((num % 4 == 0) && (num % 10 != 0))) {
             Console.WriteLine("its a Leap year");
         } else {
             Console.WriteLine("its not a Leap year");
         }
     }  
 }
