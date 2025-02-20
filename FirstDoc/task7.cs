/*

Task 17: Set or Clear the K-th Bit of a Number
Elements: simple types, without loops, bitwise operators
Task: 
1. Ask the user to specify the operation (set or clear).
2. Take the number and K.
3. Do the operation and print the output.


*/

using System;
class Program  {
    static void Main(string[] args) {
        Console.WriteLine("enter num");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("enter index");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("set or clear");
        string? s = Console.ReadLine();
        if (s == "set") {
            num |= (1 << index);
        } else if (s == "clear") {
            int one = 1 << index;
            num &= (~one);
        }
        Console.WriteLine("res: {0}", num);
    }
}
