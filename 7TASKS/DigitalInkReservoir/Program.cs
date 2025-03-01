/*

Digital Ink Reservoir
   Concept: Simulate an ink reservoir in a digital pen where ink can be added or removed when writing.
   Requirements
Implement a InkReservoir class:
1. Color (string)
2. InkAmount (double, in milliliters)
3. Overload + operator:
    Combine two ink reservoirs (if they have the same color).
    If colors differ, prevent merging.
4. Overload - operator:
    Subtract ink from a reservoir (simulating ink usage).
    Prevent negative ink levels.
5. Override ToString() to return reservoir details.

*/

using System;

class InkReservoir {
    string? _inkColor;
    double _inkAmount;

    public InkReservoir(string color, double amount) {
        if (amount < 0 || string.IsNullOrEmpty(color)) {
            throw new ArgumentException("INVALID ARGUMENT");
        }

        _inkColor = color;
        _inkAmount = amount;
    }

    public static InkReservoir operator +(InkReservoir reservoir1, InkReservoir reservoir2) => AddReservoirs(reservoir1, reservoir2);
    public static InkReservoir AddReservoirs(InkReservoir reservoir1, InkReservoir reservoir2) {
        if (reservoir1._inkColor != reservoir2._inkColor) {
           throw new ArgumentException("Colors Dont Match");
        }

        return new InkReservoir(reservoir1._inkColor!, reservoir1._inkAmount + reservoir2._inkAmount);
    }

    //Simulating spending the ink on string writing
    public static InkReservoir operator -(InkReservoir reservoir, string str) => SubReservoirs(reservoir, str);
    public static InkReservoir SubReservoirs(InkReservoir reservoir, string str) {
        if (str.Length > reservoir._inkAmount) {
           throw new ArgumentException("the string is too long");
        }

        return new InkReservoir(reservoir._inkColor!, reservoir._inkAmount - str.Length);
    }

    public override string ToString() => $"Ink Color:{_inkColor}\nInk Amount: {_inkAmount}\n";

    public void Display() {
        Console.WriteLine(this.ToString());
    }
}

class Program {
    public static void Main(string[] args) {
        InkReservoir inkReservoir1 = new InkReservoir("black", 10);
        InkReservoir inkReservoir2 = new InkReservoir("red", 100);
        InkReservoir inkReservoir3 = new InkReservoir("black", 350);

        InkReservoir res = inkReservoir1 + inkReservoir3;
        res.Display();

        //using 26 ml's of ink
        inkReservoir3 -= "this string has 26 symbols";
        inkReservoir3.Display();

        //res = inkReservoir3 + inkReservoir2; //will cause an exception;
    }
}