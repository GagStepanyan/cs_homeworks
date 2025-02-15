/*

Task 9: Finding the Longest Word in a Sentence
Task: Ask the user for a sentence and use a loop to determine the longest word.


*/

using System;
 
 class Program {
     static void Main(string[] args) {
         Console.WriteLine("enter a sentance");
         string? sentance = Console.ReadLine();
         
         string current = "";
         string longest = "";
         for (int i = 0; i < sentance.Length; i++) {
 
             char c = sentance[i];
             
             if (char.IsLetterOrDigit(c)) {
                 current += c;
             } else {
                 if (current.Length > longest.Length) {
                     longest = current;
                 }
 
                 current = "";
             }
 
             if (current.Length > longest.Length) {
                 longest = current;
             }
         }
 
         Console.WriteLine($"the longest world: {longest}");
      }

