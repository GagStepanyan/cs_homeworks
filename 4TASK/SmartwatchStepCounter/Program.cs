/*

Task 5: Smartwatch Step Counter
Task: Create a class Smartwatch with:
1. Fields: ownerName and stepCount.
2. Add methods AddSteps(int steps) and ShowSteps().
3. In Main(), create a smartwatch object, simulate adding steps, and display the total.

*/

class SmartWatch {
    string? _watchOwnerName;
    int _watchStepCount;

    public string OwnerName {
        get { return _watchOwnerName; }
        set { _watchOwnerName = value; }
    }

    public int StepCount {
        get { return _watchStepCount;}
        set { _watchStepCount = value; }
    }

    public SmartWatch(string ownerName) {
        _watchOwnerName = ownerName;    
        _watchStepCount = 0;
    }

    public void AddSteps(int count) {
        if (count <= 0) {
            Console.WriteLine("Invalid input");
            return;
        }

        _watchStepCount += count;
    }

    public void DisplayInfo() {
        Console.WriteLine();
        Console.WriteLine($"Owner Name: {_watchOwnerName}");
        Console.WriteLine($"Steps count: {_watchStepCount}");
        Console.WriteLine();
        return;
    }
}

class Program {
    static void Main(string[] args) {
        SmartWatch watch = new SmartWatch("Ariana");
        Console.WriteLine("Before going to walk");
        watch.DisplayInfo();
        Console.WriteLine("User went to walking...");
        watch.AddSteps(250);
        Console.WriteLine("After Walking");
        watch.DisplayInfo();    
    }
}