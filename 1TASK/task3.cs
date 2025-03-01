/*

Task 13: Convert Days to Weeks and Days
Elements: simple types, without loops

Task:
1. Take an integer input representing days.
2. Convert it into weeks and remaining days.
Example 
Input: 10 

Output: 1 week and 3 days

*/

using System;

 class Program {
     static void Main(string[] args) {
         int days = 0;
         Console.WriteLine("enter days");
         days = int.Parse(Console.ReadLine());
         int weeks = 0;

         Console.WriteLine("{0} weeks\n{1} days", days / 7, days % 7);
     }
 }
