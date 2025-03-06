/*

    Find the Longest Word
Task: Write a program to find the longest word from the input words array:
1. Write a method that returns the longest word from the input words array.
2. Use params in method parameters.
3. Call it with a user-provided words array.

*/

class Program {

    public static string FindTheLongestWord(params string[] words) {
        int max = 0;
        int id = -1;
        for (int i = 0; i < words.Length; ++i) {
            if (words[i].Length > max) {
                id = i;
            }
        }

        return words[id];
    }
    public static void Main(string[] args) {
        Console.Write("How many words to check?: ");
        int size = Convert.ToInt32(Console.ReadLine());
        if (size <= 0) {
            Console.WriteLine("Invalid size");
            return;
        }
        string?[] strings = new string[size];
        
        Console.WriteLine($"Enter {size} words");
        for (int i = 0; i < strings!.Length; ++i) {
            Console.Write($"{i + 1})Word: ");
            strings![i] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine($"The Longest Word is: {FindTheLongestWord(strings!)}");
        Console.WriteLine();        
    }
}