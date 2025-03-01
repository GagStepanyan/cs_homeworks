/*

Task 18: Check if a String Starts or Ends With a Specific Character
Elements: simple types, without loops, string manipulations
Task: 
1. Take a string as an user input and a specific character.
2. Check if the string starts or ends with that specific character.
3. Print the output.

*/
class Program {
    public static void main(String[] args) {
    Console.WriteLine("enter string");
         string? checkingstring = Console.ReadLine();
         Console.WriteLine("enter character");
         char symbol = char.Parse(Console.ReadLine());
         if (checkingstring.EndsWith(symbol) == true)
         {
             Console.WriteLine($"the string ends with {symbol}");
         }
         else if (checkingstring.StartsWith(symbol) == true)
         {
             Console.WriteLine($"the string starts with {symbol}");
         }
         else
         {
             Console.WriteLine($"the string not starting or ending with {symbol}");
         }
    }
}