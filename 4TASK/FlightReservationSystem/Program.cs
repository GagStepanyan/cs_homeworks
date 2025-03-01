/*

Task 2: Flight Reservation System
Task: Create a class FlightTicket with:
1. Fields: passengerName, flightNumber, and seatNumber.
2. Add a constructor to initialize these fields.
3. In Main(), create a few tickets and print the details.

*/

class FlightTicket {

    string? _ticketPassangerName;
    int _ticketFlightNumber;
    string? _ticketSeatNumber;

    public string TicketPassengerName 
    {
        get {return _ticketPassangerName!; }
    }

    public int TicketFlightNumber
    {
        get { return _ticketFlightNumber; }
    }

    public string TicketSeatNumber
    {
        get { return _ticketSeatNumber!; }
    }

    public FlightTicket(string name, int number, string seat) {
        
        _ticketPassangerName = name;
        _ticketFlightNumber = number;
        _ticketSeatNumber = seat;   

    }

    public void ShowInfo() {
        Console.WriteLine();
        Console.WriteLine($"Passanger's name: {_ticketPassangerName}");
        Console.WriteLine($"Flight number: {_ticketFlightNumber}");
        Console.WriteLine($"Seat number: {_ticketSeatNumber}");
        Console.WriteLine();
    }

}

class TicketManager {
    List <FlightTicket> _managerTickets;
    int _managerTicketsCount;

    public TicketManager() {
        _managerTickets = new List<FlightTicket>();
        _managerTicketsCount = 0;
    }

    public void AddTicket() {
        Console.Write("Enter passanger's Name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter the seat number: ");
        string? seat = Console.ReadLine();
        Console.Write("Enter the flight number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //preventing double registration

        for (int i = 0; i < _managerTicketsCount; ++i) {
            if (seat == _managerTickets[i].TicketSeatNumber && number == _managerTickets[i].TicketFlightNumber) {
                Console.WriteLine("\nDouble Register is not allowed!!!\n");
                return;
            }
        }

        _managerTickets.Add(new FlightTicket(name!, number, seat!));
        ++_managerTicketsCount;
        Console.WriteLine("\nThe Ticket Was Successfully Added\n");

    }

    public void RemoveTicket() {
        Console.WriteLine("\nPreparing for removing\n");
        Console.Write("Enter the flight number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the seat: ");
        string? seat = Console.ReadLine();
        for (int i = 0; i < _managerTicketsCount; ++i) {
            if (_managerTickets[i].TicketFlightNumber == number && _managerTickets[i].TicketSeatNumber == seat) {
                _managerTickets.Remove(_managerTickets[i]);
                --_managerTicketsCount;
                break;
            }
            if (i == _managerTicketsCount - 1) {
                Console.WriteLine("Such Flight Was Not Found...");
            }
        }
        Console.WriteLine("\nThe Ticket Was Successfully Removed\n");

    }

    public void ShowInfoInList() {
        for (int i = 0; i < _managerTicketsCount; ++i) {
            _managerTickets[i].ShowInfo();
        }
    }

    public static void Run() {
         Console.WriteLine("Welcome !");
        TicketManager manager = new TicketManager();
        string? answ;

        while (true) {
            Console.WriteLine();
            Console.WriteLine("Press '+' to add a new ticket");
            Console.WriteLine("Press '-' to remove a ticket");
            Console.WriteLine("Press 'L' to show all tickets");
            Console.WriteLine("Press 'X' to exit");
            Console.WriteLine();
            answ = Console.ReadLine();
            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "+") {
                manager.AddTicket();
            } else if (answ == "-") {
                manager.RemoveTicket();
            } else if (answ == "l" || answ == "L") {
                manager.ShowInfoInList();
            } else {
                Console.WriteLine("Invalid Command, Try Again");
            }
        }

        Console.WriteLine("GoodBye !");
    }
}

class Program {
    public static void Main() {
       TicketManager.Run();
    }
}
