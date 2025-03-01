/*

Task 7: Ticket Booking System
Task: Create a MovieTicket class with:
1. MovieName, SeatNumber, IsBooked.
2. A method BookTicket() that marks it as booked.
3. In Main(), create 5 seats, allow the user to book one, and prevent double booking.
4. Show all available seats before booking.

*/


using System;

class MovieTicket {
    string? _ticketMovieName;
    int _ticketSeatNumber;
    bool _ticketIsBooked;
    
    public string MovieName
    {
        get { return _ticketMovieName!; }
    }

    public int SeatNumber
    {
        get {return _ticketSeatNumber; }
    }

    public bool IsBooked
    {
        get { return _ticketIsBooked;}
    }

    public MovieTicket(string movename, int seatnumber) {
        _ticketMovieName = movename;
        _ticketSeatNumber = seatnumber;
        _ticketIsBooked = false;
    }

    
    public void BookTicket() {
        if (IsBooked) {
            Console.WriteLine("this ticket is already booked");
            return;
        } else {
            _ticketIsBooked= true;
            Console.WriteLine($"You booked ticket for {_ticketMovieName} at seat {_ticketSeatNumber}, thank you!!!");
            return;
        }
    }

    public void ShowInfo() {
        Console.WriteLine($"Movie Name: {_ticketMovieName}");
        Console.WriteLine($"Seat Number: {_ticketSeatNumber}");
        Console.WriteLine();
    }
    
} 

class Program {
    static void Main(string[] args) {
        MovieTicket[] tickets = new MovieTicket[5];

        for (int i = 0; i < tickets.Length; ++i) {
            tickets[i] = new MovieTicket("The GodFather",i + 1);
        }

    Console.WriteLine("Welcome to Central Cinema\n");

    while (true) {
        Console.WriteLine("This is the available List\n");
        for (int i = 0; i < tickets.Length; ++i) {
            if (!tickets[i].IsBooked) {
                tickets[i].ShowInfo();
            }
        }
        Console.WriteLine("do you want to book any? y/n");
        string? answ = Console.ReadLine();
        if (answ == "y" || answ == "Y") {
            label: 
            Console.WriteLine("choose the seat");
            int seat = Convert.ToInt32(Console.ReadLine());
            if (seat < 1 || seat > 5) {
                Console.WriteLine("not valid seat number");
                goto label;
            }
            tickets[seat - 1].BookTicket();
                        
        } else if (answ == "n" || answ == "N") {
            Console.WriteLine("Thank you, goodbye!");
            break;
        }      
    }

    }
}