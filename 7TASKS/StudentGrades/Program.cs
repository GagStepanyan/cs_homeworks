/*

Student Grades
Task: Create a Students class that stores grades:
1. Implement an indexer where:
       The key is a subject name.
       The value is a grade.
       If the subject doesn’t exist, return -1.
2. Use only arrays.

*/

using System;

class Students {
    int[] _studentsGrades;
    string[] _studentsSubject;
    int _studentsTotalCount;

    public Students(int capacity) {
        if (capacity < 0) {
            throw new ArgumentException("invalid argument");
        }
        _studentsGrades = new int[capacity];
        _studentsSubject = new string[capacity];
        _studentsTotalCount = 0;
    }

    public int this[string subject] {
        get {
            for (int i = 0; i < _studentsTotalCount; ++i) {
                if (_studentsSubject[i] == subject) {
                    return _studentsGrades[i];
                }
            }
            
            return -1;
        }

        set {
            for (int i = 0; i < _studentsTotalCount; ++i) {
                if (_studentsSubject[i] == subject) {
                    _studentsGrades[i] = value;
                    return;
                }
            }

            if (_studentsTotalCount < _studentsSubject.Length) {
                _studentsSubject[_studentsTotalCount] = subject;
                _studentsGrades[_studentsTotalCount] = value;
                ++_studentsTotalCount;
            } else {
                Console.WriteLine("Storage is full");
                return;
            }
        }
    }
}

class Program {
    static void Main(string[] args) {
        Students student = new Students(5); // Capacity for 5 subjects

        student["Math"] = 90;
        student["Science"] = 85;
        student["History"] = 95;

        Console.WriteLine($"Math Grade: {student["Math"]}");
        Console.WriteLine($"English Grade: {student["English"]}"); // Should output -1
        student["English"] = 77;
        Console.WriteLine($"English Grade: {student["English"]}");
        student["Programming"] = 99;
        Console.WriteLine($"Programing Grade: {student["Programming"]}");
        student["Art"] = 100;

        student["ExtraSubject"] = 100; // Will print 'storage is full' to console.
    }
}