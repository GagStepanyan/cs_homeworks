/*
Task 20: Create a Jagged Array and Fill It with Numbers 
Elements: simple types, jagged array
Task: 
1. Create a jagged integer array 
2. Fill it with numbers.
3. Print the array.

*/

class Program {
    static void Main (string [] args) {
        int [][] arr = new arr[3][];
        arr[0] = new int[] {1, 2, 3,};
        arr[1] = new int[] {1, 2, 3, 4, 5};
        arr[2] = new int[] {1};

        for (int i = 0; i < arr.Length; ++i) {
            for (int j = 0; j < arr[i].Length; ++j) {
                Console.WriteLine($"{arr[i][j]}")
            }
        } 
    }
}