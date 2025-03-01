using System;
public partial class Character {
    public void DisplayInfo() {
        Console.WriteLine("\nCharacter Info");
        Console.WriteLine($"Name: {_characterName}");
        Console.WriteLine($"Level: {_characterLevel}");
        Console.WriteLine();
    }
}