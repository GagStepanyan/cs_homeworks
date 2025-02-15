/*

Task 8: Password Generator
Task: Create a loop-based random password generator with at least one uppercase letter, one lowercase letter, and one digit.

*/

using System;
 
 class Program {
     static void Main(string[] args) {
         char [] uppers = {'A', 'Z', 'X', 'Y', 'Z', 'B', 'V', 'G'};
         char [] lowers = {'a', 'z', 'x', 'y', 'z', 'b', 'v', 'g'};
         char [] symbols = {'*', '$', '@', '#', '%', '^', '&', '?'};
         char [ZZ] numbers = {'0', '1', '2', '3', '4', '5', '6', '7'};
         Random rndGenerator = new Random();
         while (true) {
             Console.WriteLine("enter \'a\' to generate a password, \'x\' to exit");
             char key = char.Parse(Console.ReadLine());
             if (key == 'x') {
                 goto exitLabel;
 
             } else if (key == 'a') {
                 char[] arr = new char[8];
                 for (int i = 0; i < 8; ) {
                     if (i >= 8) {
                         break;
                     }
                     arr[i++] = uppers[rndGenerator.Next(0,8)];
                     if (i >= 8) {
                         break;
                     }
                      arr[i++] = lowers[rndGenerator.Next(0,8)];
                     if (i >= 8) {
                         break;
                     }
                      arr[i++] = symbols[rndGenerator.Next(0,8)];
                     if (i >= 8) {
                         break;
                     }
                      arr[i++] = numbers[rndGenerator.Next(0,8)];
 
 
                 }
                 string myString = new string(arr);
                 Console.WriteLine(myString);
 
             } else {
                 Console.WriteLine("invalid input, please be attended\n");
             }
         }
     
     exitLabel:
         Console.WriteLine("exiting...");
     }
 }


