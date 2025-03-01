/*

Task 4: Book Library
Task: Create a Book class with:
1. Title, Author, IsAvailable properties.
2. A method BorrowBook() that sets IsAvailable = false.
3. A method ReturnBook() that sets IsAvailable = true.
4. In Main(), create 3 books, borrow one, and display availability status.
5. Allow user interaction (choose which book to borrow/return).

*/

using System;

class Book {
    string? _bookTitle;
    string? _bookAuthor;
    bool _bookIsAvailable;

    public string Title
    {
        get { return _bookTitle!; }
        set { _bookTitle = value; }
    }

    public string Author
    {
        get { return _bookAuthor!; }
        set { _bookAuthor = value; }
    }

    public Book(string title, string author) {
        _bookTitle = title;
        _bookAuthor = author;
        _bookIsAvailable = true;
    }

    public void BorrowBook() {
        if (!_bookIsAvailable) {
            Console.WriteLine("The book hasn't been returned yet");
            return;
        }
        _bookIsAvailable = false;
        Console.WriteLine("You borrowed a book");
    }

    public void ReturnBook() {
        if (_bookIsAvailable) {
            Console.WriteLine("ilegal action");
        }
        _bookIsAvailable = true;
        Console.WriteLine("Thank you!");
    }    

    public void ShowInfo() {
        Console.WriteLine($"the Title: {_bookTitle}");
        Console.WriteLine($"the Author's name: {_bookAuthor}");
        if (_bookIsAvailable) {
            Console.WriteLine("status: Is Available");
        } else {
            Console.WriteLine("status: Isn't Available");
        }
            Console.WriteLine();

            return;
    }

    public static void Run() {

        Book[] books = new Book[3];

        books[0] = new Book("The Prince", "Niccolo Machiavelli");
        books[1] = new Book("Mein Kampf", "Adolf Hitler");
        books[2] = new Book("The Art of War", "Sun Tzu");

        Console.WriteLine("this is what we have\n");
        Console.WriteLine("**************************************************************************");
        for (int i = 0; i < books.Length; ++i) {
            books[i].ShowInfo();
        }
        Console.WriteLine("**************************************************************************");

        while (true) {
            Console.WriteLine("press 'b' to borrow a book, 'r' to return a book, 'x' to exit the program");
            Console.WriteLine("press 'l' to see the assorty list");
            string? c = Console.ReadLine();

            if (c == "b") {

                    Console.WriteLine("which book you want to borrow?");
                    Console.WriteLine("tell me a title ");
                    string? title = Console.ReadLine();
                    Console.WriteLine("tell me the Authors name ");
                    string? name = Console.ReadLine();

                    for (int i = 0; i < books.Length; ++i) {
                        if (books[i].Author.Equals(name) && books[i].Title.Equals(title)) {
                            books[i].BorrowBook();
                            break;
                        }

                        if (i == books.Length - 1) {
                            Console.WriteLine("we dont have such book");
                        }
                    }

            }  else if (c == "r") {
                Console.WriteLine("which book you want to Return?");
                    Console.WriteLine("tell me a title ");
                    string? title = Console.ReadLine();
                    Console.WriteLine("tell me the Authors name ");
                    string? name = Console.ReadLine();

                    for (int i = 0; i < books.Length; ++i) {
                        if (books[i].Author.Equals(name) && books[i].Title.Equals(title)) {
                            books[i].ReturnBook();
                            break;
                        }

                        if (i == books.Length - 1) {
                            Console.WriteLine("we dont have such book");
                        }
                    }
            } else if (c == "x") {
                break; 
            } else if (c == "l") {
                for (int i = 0; i < books.Length; ++i) {
                    books[i].ShowInfo();
                }
            } else {
                Console.WriteLine("unknown command... try again");
            }



        }

        Console.WriteLine("final Status\n");
            for (int i = 0; i < books.Length; ++i) {
                books[i].ShowInfo();
            } 
        

    }

}

class Program {
    static void Main(string[] args) {
        Book.Run();
    }
}
