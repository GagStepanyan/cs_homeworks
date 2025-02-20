/*

Task 15: Check Uppercase or Lowercase
Elements: simple types, without loops

Task: 
1. Ask the user to enter a character.
2. Determine if it is uppercase, lowercase, or neither.
 Hint: Use char.IsUpper() and char.IsLower().

*/

using System;
 
class Program {
     static void Main(string[] args) {
         Console.WriteLine("enter a character");
         char ch = char.Parse(Console.ReadLine());
         if (char.IsUpper(ch)) {
             Console.WriteLine("is Upper");
         } else if (char.IsLower(ch)) {
             Console.WriteLine("is Lower");
         } else {
             Console.WriteLine("invalid input");
         }
     }  
}
