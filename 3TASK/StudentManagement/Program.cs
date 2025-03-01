/*

Task 2: Student Management
Task: Create a Student class with:
1. Name, Age, and Grade properties.
2. A DisplayDetails() method.
3. In Main(), create 5 students, store them in an array, and display their details.

*/

using System;

class Student {
     string? _studentName;
     string? _studentAge;
     string? _studentGrade;

    public string Name
    {
        get { return _studentName!; }
        set { _studentName = value; }
    }

    public string Age
    {
        get { return _studentAge!;}
        set { _studentAge = value; }
    }

    public string Grade
    {
        get {return _studentGrade!;}
        set { _studentGrade = value;}
    }

    public Student () {
        Console.WriteLine("enter name");
        _studentName = Console.ReadLine();

        Console.WriteLine("enter age");
        _studentAge = Console.ReadLine();

        Console.WriteLine("enter grade");
        _studentGrade = Console.ReadLine();
    }
   

        public void DisplayInfo() {
            Console.WriteLine($"Name: {_studentName}");
            Console.WriteLine($"Age: {_studentAge}");
            Console.WriteLine($"Grade: {_studentGrade}");
            Console.WriteLine();
        }
}

class Program {
    static void Main(string[] args) {

        Student[] students = new Student[5];

        for (int i = 0; i < students.Length; ++i) {
            students[i] = new Student(); 
        }

        for (int i = 0; i < students.Length; ++i) {
            students[i].DisplayInfo();
        }

    }
}