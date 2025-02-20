/*

Task 10: Maze Solver (Grid Navigation)
Task: Create a 10x10 grid, place an "X" in one random location, and move a player (P) using loop-based logic to find "X".

*/

 using System;
 
 class Program {
     static void Main(string[] args) {
         char[,] mtx = new char[10,10];
 
         Random id1 = new Random();
         Random id2 = new Random();
 
         mtx[id1.Next(0,10), id2.Next(0,10)] = 'X';
 
         for (int i = 0; i < 10; ++i) {
             for (int j = 0; j < 10; ++j) {
                 if (mtx[i,j] == 'X') {
                     Console.WriteLine("\'X\' was found at mtx[{0}][{1}]", i, j);
                     return;
                 }
             } 
         }

		 Console.WriteLine("the \'X\' was not found\n");
     }      
 }
