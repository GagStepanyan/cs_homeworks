/*

Computed Property with String Formatting
Task: Create a TimePeriod class with:
1. A property TotalSeconds (int).
2. A computed property FormattedTime that returns "HH:mm:ss" format.

*/
using System;
class TimePeriod {
    int _periodSeconds;

    public TimePeriod(int periodSeconds) {
        if (periodSeconds < 0) {
            throw new ArgumentException("illegal argument");
        }
        _periodSeconds = periodSeconds;
    }
    public string FormattedTime {
        get {
            int hours = _periodSeconds / 3600;
            int minutes = (_periodSeconds % 3600) / 60;
            int seconds = (_periodSeconds % 60);

            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }

    public void Display() {
        Console.WriteLine(this.FormattedTime);
    }
}

class Program {
    static void Main(string[] args) {
        TimePeriod period = new TimePeriod(7400);
        period.Display();

    }
}

