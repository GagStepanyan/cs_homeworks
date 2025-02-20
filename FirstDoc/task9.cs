/*
Task 19: Create a 2D Array and Fill It with Numbers 
Elements: simple types, 2D array manipulations
Task: 
Create a 2D integer array with fixed rows and columns (3x3).
Fill it with numbers.
Print the array.
*/

class Program {
    static void Main(string[] args) {

       Console.WriteLine("enter the matrix size");
         int size = int.Parse(Console.ReadLine());
         int[,] array = new int[size,size];
         for (int i = 0; i < size; i++) {
             for (int j = 0; j < size; j++) {
                 array[i,j] = int.Parse(Console.ReadLine());
             }
         }
         for (int i = 0; i < size; i++) {
             for (int j = 0; j < size; j++) {
                 Console.Write($"{array[i,j]} ");
             }
             Console.WriteLine();
         }
        
        Console.WriteLine("the X was not found");

    }

}
