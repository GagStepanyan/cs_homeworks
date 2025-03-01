/*

Task 1: Student Management System
Task: Create a class Student with:
1. Fields: name, studentID, and gradeLevel.
2. Add a method ShowStudentInfo() to display the details.
3. In Main(), create a few Student objects and display their details.

*/
using System;

class Student {
    static int _studentInstanceCount = 0;
    string? _studentName;
    string? _studentID;
    int _studentGradeLevel;

    public string StudentName {
        get { return _studentName!; }
        set { _studentName = value; }
    }

    public string StudentID {
        get { return _studentID!; }
        set { _studentID = value; }
    }

    public int StudentGradeLevel {
        get { return _studentGradeLevel;}
        set { _studentGradeLevel = value; }
    }

    public Student (string name, int grade) {
        ++_studentInstanceCount;
        
        _studentName = name;
        _studentGradeLevel = grade;
        if (_studentInstanceCount < 10) {
            _studentID = $"000{_studentInstanceCount}";
        } else if (_studentInstanceCount < 100) {
        _studentID = $"00{_studentInstanceCount}";
        } else if (_studentInstanceCount < 1000) {
            _studentID = $"0{_studentInstanceCount}";
        } else {
            _studentID = $"{_studentInstanceCount}";
        }

    }
 
    public void ShowInfo() {
        Console.WriteLine();
        Console.WriteLine($"Student's name: {_studentName}");
        Console.WriteLine($"Student's Grade level: {_studentGradeLevel}");
        Console.WriteLine($"Student's ID: {_studentID}");
        Console.WriteLine();
    }

    
}

class StudentManager {
    List <Student> _managerStudents;
    int _managerStudentsCount;

    public StudentManager() {
        _managerStudents = new List<Student>();
        _managerStudentsCount = 0;
    } 

    public void AddStudent() {
        Console.Write("Enter student's name: ");
        string? name = Console.ReadLine();
        Console.Write("Enter student's grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        _managerStudents.Add(new Student(name,grade));
        ++_managerStudentsCount;
        Console.WriteLine("\n Student was added successfully\n");
    }

    public void RemoveStudent() {
        Console.Write("Enter student's ID to remove: ");
        string? id = Console.ReadLine();
        for (int i = 0; i < _managerStudentsCount; ++i) {
            if (_managerStudents[i].StudentID == id) {
                _managerStudents.Remove(_managerStudents[i]);
                --_managerStudentsCount;
                break;
            }
            if (i == _managerStudentsCount - 1) {
                Console.WriteLine("\n student was not found\n");
            }

        }
        Console.WriteLine("\n Student was removed successfully\n");
    }

    public void ShowInfoInList() {
        for (int i = 0; i < _managerStudentsCount; ++i) {
            _managerStudents[i].ShowInfo();
        }
    }

}

class Program {
    public static void Main(String[] args) {
       StudentManager manager = new StudentManager();

       string? answ;

       while (true) {
            Console.WriteLine();
            Console.WriteLine("Press '+' to add a student");
            Console.WriteLine("Press '-' to remove a student");
            Console.WriteLine("Press 'L' to show all students");
            Console.WriteLine("Press 'X' to exit");
            Console.WriteLine();
            answ = Console.ReadLine();
            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "+") {
                manager.AddStudent();
            } else if (answ == "-") {
                manager.RemoveStudent();
            } else if (answ == "L" || answ == "l") {
                manager.ShowInfoInList();
            } else {
                Console.WriteLine("Invalid Command, Try Again");
            }
       }

       Console.WriteLine("\nGood Bye!\n");
    }
}