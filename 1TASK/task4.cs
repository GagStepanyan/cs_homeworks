/*

Task 14:  Find the Type of Triangle
Elements: simple types, without loops

Task: 
1. Ask the user for three sides of a triangle.
2. Determine if it is:
Equilateral (all sides equal)
Isosceles (two sides equal)
Scalene (no sides equal)


*/

using System;
 
 class Program {
     static void Main(string[] args) {
         Console.WriteLine("enter threeangle's sides");
         int first = 0;
         int second = 0;
         int third = 0;
 
     
         first = int.Parse(Console.ReadLine());
         second = int.Parse(Console.ReadLine());
         third = int.Parse(Console.ReadLine());
 
         if (first == second && first == third  && second == third) {
             Console.WriteLine("Equilatera");
         } else if (first == second || first == third || third == second) {
             Console.WriteLine("Isosceles");
         } else if (first != second && first != third  && second != third) {
             Console.WriteLine("Scalene");
         }
     }  
 }
