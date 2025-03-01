/*

Convert Temperature
Task: Write a program for temperature conversion:
Write a method that converts Celsius to Fahrenheit and Kelvin.
Use ref and out in method parameters.
Call it with a user-provided Celsius value.

*/


class Program {

    public static void ConvertToFahrenheitAndKelvin(ref double cels, out double fah, out double kel) {
        fah = (cels * 1.8) + 32;
        kel = cels + 273.15;
    }
    public static void Main(string[] args) {
        Console.WriteLine("Enter Celsius");
        double cels = Convert.ToDouble(Console.ReadLine());
        double fah, kel;
        ConvertToFahrenheitAndKelvin(ref cels, out fah, out kel);
        Console.WriteLine($"Fahrenheit: {fah}");
        Console.WriteLine($"Kelvin: {kel}");
    }
}