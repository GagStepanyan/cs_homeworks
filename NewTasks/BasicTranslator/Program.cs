using System;

public abstract class Translator
{
    public abstract string Translate(string word);
}

public class Russian : Translator
{
    private static readonly string[] _englishWords = {"apple", "banana", "orange", "mango", "pineaple", "grape", "strawberry", "cherry", "watermelon", "peach"};
    private static readonly string[] _russianTranslations = {"яблоко", "банан", "апельсин", "манго", "ананас", "виноград", "клубника", "вишня", "арбуз", "персик"};

    public override string Translate(string word)
    {
        string lower = word.ToLower();

        for (int i = 0; i < _englishWords.Length; ++i)
        {
            if (_englishWords[i] == lower)
            {
                return _russianTranslations[i];
            }
        }

        return $"Translation for word {word} was not found.";
    }
}

public class Spanish : Translator
{
   private static readonly string[] _englishWords = {"apple", "banana", "orange", "mango", "pineaple", "grape", "strawberry", "cherry", "watermelon", "peach"};
    private static readonly string[] _spanishTranslations = {"manzana", "banana", "naranja", "mango", "piña", "uva", "fresa", "cereza", "sandía", "durazno"};

    public override string Translate(string word)
    {
        string lower = word.ToLower();

        for (int i = 0; i < _englishWords.Length; ++i)
        {
            if (_englishWords[i] == lower)
            {
                return _spanishTranslations[i];
            }
        }

        return $"Translation for word {word} was not found.";
    }

}

public class French : Translator
{
    private static readonly string[] _englishWords = {"apple", "banana", "orange", "mango", "pineaple", "grape", "strawberry", "cherry", "watermelon", "peach"};
    private static readonly string[] _spanishTranslations = {"pomme", "banane", "orange", "mangue", "ananas", "raisin", "fraise", "cerise", "pastèque", "pêche"};

    public override string Translate(string word)
    {
        string lower = word.ToLower();

        for (int i = 0; i < _englishWords.Length; ++i)
        {
            if (_englishWords[i] == lower)
            {
                return _spanishTranslations[i];
            }
        }

        return $"Translation for word {word} was not found";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Translator[] translators = new Translator[3];
        translators[0] = new Russian();
        translators[1] = new Spanish();
        translators[2] = new French();

        string[] wordsToTranslate = {"apple", "banana", "orange", "mango", "pineaple", "grape", "strawberry", "cherry", "watermelon", "peach"};

        foreach (Translator translator in translators)
        {
            Console.WriteLine();
            Console.WriteLine($"Translation from English to {translator.GetType().Name}: ");
            Console.WriteLine();

            foreach (string word in wordsToTranslate)
            {
                Console.WriteLine($"{word} : {translator.Translate(word)}");
            }
        }
    }
}
