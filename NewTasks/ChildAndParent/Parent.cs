namespace ParentAndChild;

using System;

class Parent
{
    string? _parentName;
    int _parentAge;
    int _parentSalary;

    public Parent(string name, int age, int salary)
    {
        _parentName = name;
        _parentAge = age;
        _parentSalary = salary; 
    }

    public string? Name
    {
        get => _parentName;
    }

    public int Age
    {
        get => _parentAge;
    }

    public int Salary
    {
        get => _parentSalary;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Parent's Name: {_parentName}");
        Console.WriteLine($"Parent's Age: {_parentAge}");
        Console.WriteLine($"Parent's Salary: {_parentSalary}");
        Console.WriteLine();
    }

}