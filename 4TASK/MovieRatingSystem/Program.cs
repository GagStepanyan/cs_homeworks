/*

Task 6: Movie Rating System
Task: Create a class Movie with:
1. Private field _rating.
2. Add a property Rating that:
3. Allows setting a value between 1 and 5.
4. Prints a warning if an invalid value is entered.
5. In Main(), test the property with valid and invalid values.

*/

using System;

class Movie {
    int _moveRating;
    public int Rating {
        get { return _moveRating; }
        set { 
            if (value >= 0 && value <= 5) {
                _moveRating = value;
            } else {
                Console.WriteLine("Invalid input rating, try again");
            }
         }
    }




}

class Program {
    static void Main(string[] args) {
        Movie movie = new Movie();

        Console.WriteLine("Testing valid ratings:");

        movie.Rating = 3;
        Console.WriteLine($"Rating set to: {movie.Rating}");

        movie.Rating = 5;
        Console.WriteLine($"Rating set to: {movie.Rating}");

        movie.Rating = 1;
        Console.WriteLine($"Rating set to: {movie.Rating}");

        Console.WriteLine("\nTesting invalid ratings:");

        movie.Rating = 0;
        Console.WriteLine($"Rating (should not change): {movie.Rating}");

        movie.Rating = 6;
        Console.WriteLine($"Rating (should not change): {movie.Rating}");

        movie.Rating = -1;
        Console.WriteLine($"Rating (should not change): {movie.Rating}");

    }
}