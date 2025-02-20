/*

Task 1: Fibonacci Sequence Generator
Task: Write a program that generates the first N numbers of the Fibonacci sequence using a loop.

*/
using System;
 class Program {
     static void Main(string[] args) {
         int fibo;
         int first = 0;
         int second = 1;
         int current = first + second; //0,1,1,2,3,5,8

         Console.WriteLine("enter a number: ");
         fibo = int.Parse(Console.ReadLine());

         if (fibo == 0 || fibo == 1) {
             Console.WriteLine($"{fibo}");
         }
         while (fibo != 0) {
             current = first + second;
             first = second;
             second = current;
             --fibo;
         }

         Console.WriteLine("the number is {0}", current);

     }
 }
