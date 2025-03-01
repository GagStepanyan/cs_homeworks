/*

    Time Converter
Task: Write a program that converts seconds to time:
1. Write a method that converts totalSeconds into hours, minutes, and seconds.
2. Use ref and out in method parameters.
3. Call it with a user-provided totalSeconds.

*/

using System;


class Program {

    static void ConvertTime(ref int seconds, out int minutes, out int hours) {
        hours = seconds / 3600;
        seconds %= 3600;
        minutes = seconds / 60;
        seconds %= 60;

        return;
    }
    static void Main(string[] args) {
        Console.WriteLine("Enter seconds");
        int seconds = Convert.ToInt32(Console.ReadLine());
        int cseconds = seconds;
        int hours, minutes;
        ConvertTime(ref seconds, out minutes, out hours);
        Console.WriteLine();
        Console.WriteLine("Displaying in format 'h:m:s'");
        Console.WriteLine($"{cseconds} seconds is: {hours}:{minutes}:{seconds}");
        Console.WriteLine();
    }
}