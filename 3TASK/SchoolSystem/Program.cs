/*

Task 8: School System
Task: Create a School Management System with:
1. Student class (Name, Age, Grade).
2. Teacher class (Name, Subject, YearsOfExperience).
3. School class that stores students & teachers in an array.
4. Show students with the highest grade and teachers with less than 2 years experience.

*/
using System;

class Student {
    string? _studentName;
    int _studentAge;
    int _studentGrade;


    public string StudentName
    {
        get { return _studentName!; }
    } 
    public int StudentAge
    {
        get { return _studentAge!; }
    }

    public int StudentGrade
    {
        get { return _studentGrade!; }
    } 

    public Student(string name, int age, int grade) {
        _studentName = name;
        _studentAge = age;
        _studentGrade = grade;
    }

    public void ShowInfoS() {
        Console.WriteLine();
        Console.WriteLine("STUDENT");
        Console.WriteLine($"Name: {_studentName}");
        Console.WriteLine($"Age: {_studentAge}");
        Console.WriteLine($"Grade: {_studentGrade}");
        Console.WriteLine();
    }
    
}

class Teacher {
    string? _teacherName;
    string? _teacherSubject;
    double _teacherYearsOfExperience;

    public string TeacherName 
    {
        get { return _teacherName!; }
    }

    public string TeacherSubject 
    {
        get { return _teacherSubject!; }
    }

    public double YearsOfExperience
    {
        get {return _teacherYearsOfExperience; }
    }

    public Teacher (string name, string subject, double years) {
        _teacherName = name;
        _teacherSubject = subject;
        _teacherYearsOfExperience = years;
    }

    public void ShowInfoT() {
        Console.WriteLine();
        Console.WriteLine("TEACHER");
        Console.WriteLine($"Name: {_teacherName}");
        Console.WriteLine($"Subject: {_teacherSubject}");
        Console.WriteLine($"Years of Experience: {_teacherYearsOfExperience}");
        Console.WriteLine();
    }
    
}

public class School {
    private Student[] students;
    private Teacher[] teachers;
    private int studentsCount;
    private int teachersCount;

    public School (int maxStudents, int maxTeachers) {
        students = new Student[maxStudents];
        teachers = new Teacher[maxTeachers];
        studentsCount = 0;
        teachersCount = 0;
    }

    public void AddStudent() {
        if (studentsCount >= students.Length) {
            Console.WriteLine($"Student's count has reached the maximum: {students.Length}");
            return;
        } else {
            Console.WriteLine("Enter student's name");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter student's age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student's grade");
            int grade = Convert.ToInt32(Console.ReadLine());
            students[studentsCount] = new Student(name!, age, grade);
            ++studentsCount;
        }
    }

    public void AddTeacher() {
        if (teachersCount >= teachers.Length) {
            Console.WriteLine($"Teacher's count has reached the maximum: {teachers.Length}");
        } else {
            Console.WriteLine("enter teacher's name");
            string? name = Console.ReadLine();
            Console.WriteLine("enter teacher's subject");
            string? subject = Console.ReadLine();
            Console.WriteLine("enter teacher's years of experience");
            double years = Convert.ToDouble(Console.ReadLine());
            teachers[teachersCount] = new Teacher(name!, subject!, years);
            ++teachersCount;
            
        }
    }
    
    public void HighestGradedStudent() {
        Student tmp;
        for (int i = 0; i < students.Length - 1; ++i) {
            for (int j = 0; j < students.Length - 1 - i; ++j) {
                if (students[j].StudentGrade < students[j + 1].StudentGrade) {
                tmp = students[j];
                students[j] = students[j + 1];
                students[j + 1] = tmp;
                }
            }
        }

        Console.WriteLine("\nTop 3 best graded students\n");
        int brakePoint = 3;
        for (int i = 1; i <= students.Length; ++i) {
            if (i > brakePoint) { break; }
            Console.Write($"{i})");
            students[i - 1].ShowInfoS();
        }

    }

    public void LessExperiencedTeachers() {

        int id = 1;
        for (int i = 0; i < teachers.Length; ++i) {
            if (teachers[i].YearsOfExperience <= 2) {
                Console.WriteLine($"{id})");
                teachers[i].ShowInfoT();
                ++id;
            }
        }

        return;
    }

    public static void Run() {
        Console.WriteLine("how many students are in school ?");
        int studentsCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("how many teachers are in school ?");
        int teachersCount = Convert.ToInt32(Console.ReadLine());
      
        School school = new School(studentsCount, teachersCount);
      
        Console.WriteLine("please register students info");
        for (int i = 0; i < studentsCount; ++i) {
            school.AddStudent();
        }

        Console.WriteLine("please register teachers info");
        for (int i = 0; i < teachersCount; ++i) {
            school.AddTeacher();
        }

        school.HighestGradedStudent();
        school.LessExperiencedTeachers();

    }
}

class Program {
    static void Main(string[] args) {
      School.Run();
        
    }
}