/*

Task 16:  Find BMI (Body Mass Index)
Elements: simple types, without loops

Task: 
1. Take the weight (kg) and height (m) as inputs.
2. Calculate BMI using a given formula (BMI = weight / height^2).
3. Categorize the result and print the output:
BMI < 18.5 → Underweight
18.5 - 24.9 → Normal weight
25 - 29.9 → Overweight
BMI ≥ 30 → Obese


*/

using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("enter your weight in KiloGrams");
        float weight = float.Parse(Console.ReadLine());
        Console.WriteLine("enter your highth in Meters");
        float highth = float.Parse(Console.ReadLine());

        float bmi = weight / (highth * highth);

        if (bmi < 18.5) {
            Console.WriteLine("Under Weight");
        } else if (bmi >= 18.5 && bmi <= 24.9) {
            Console.WriteLine("Normal Weigth");
        } else if (bmi >= 25 && bmi <= 29.9) {
            Console.WriteLine("Over Weigth");
        } else {
            Console.WriteLine("Obese");
        }
    }
}
