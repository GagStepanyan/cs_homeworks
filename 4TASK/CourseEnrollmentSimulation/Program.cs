/*

Task 10: Simulating Course Enrollment
Task: Create a class Course with:
1. Fields: courseName, instructor, and maxStudents.
2. Use a constructor to initialize these fields.
3. Add a method ShowCourseDetails().
4. In Main(), create a few courses and display their details.

*/

class Course {
    string? _courseName;
    string? _courseInstructor;
    int _courseMaxStudents;

    public Course(string name, string instructor, int maxStudents) {
        _courseName = name;
        _courseInstructor = instructor;
        _courseMaxStudents = maxStudents;
    }

    public void DisplayInfo() {
        Console.WriteLine();
        Console.WriteLine("Course Info");
        Console.WriteLine($"Name: {_courseName}");
        Console.WriteLine($"Instructor: {_courseInstructor}");
        Console.WriteLine($"Maximum students: {_courseMaxStudents}");
        Console.WriteLine();
    }
}   


class Program {
    static void Main() {
        Course[] courses = new Course[3];

        courses[0] = new Course("C# Core Mastery", "Kima Khachatryan", 20);
        courses[1] = new Course("Introduction to Computer Sience", "Hayk Darbinyan", 25);
        courses[2] = new Course("Advanced C Language", "Tamara Babayan", 25);

        for (int i = 0; i < courses.Length; ++i) {
            courses[i].DisplayInfo();
        }
    }
}