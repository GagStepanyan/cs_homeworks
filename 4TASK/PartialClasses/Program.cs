/*

Task 9: Game Character System
Task: Create a partial class.
1. Create a partial class Character in two separate files:
2. One part contains fields characterName and level.
3. The other contains a method ShowCharacterInfo().
4. In Main(), create a Character object and call ShowCharacterInfo().

*/

public class Program {
    public static void Main(String[] args) {
        Character character = new Character();
        character.Name = "Yasuo";
        character.Level = 15;
        character.DisplayInfo();

    }
}