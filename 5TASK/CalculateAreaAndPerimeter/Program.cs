/*

    Calculate Area and Perimeter
Task: Write a program for circle basic calculations:
1. Write a method that calculates area and perimeter of a circle from radius.
2. Use ref and out in method parameters.
3. Call it with a user-provided radius value.

*/

using System;
class Program {

    public static void Calculate(ref double radius, out double area, out double perimeter) {
        area = 3.14f * radius * radius;
        perimeter = radius * radius;

        return;
    }
    public static void Main(string[] args) {
        Console.WriteLine("Enter circle's radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area, perimeter;
        Calculate(ref radius, out area, out perimeter);
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");

    }
}