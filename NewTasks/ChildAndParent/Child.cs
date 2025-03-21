namespace ParentAndChild;

using System;

class Child
{
    string? _childName;
    int _childAge;
    Parent? _childFather;
    Parent? _childMother;

    public Child(string? name, int age, Parent? father, Parent? mother)
    {
        _childName = name;
        _childAge = age;
        _childFather = father;
        _childMother = mother;
    }

    public string? Name 
    {
        get => _childName;
    }

    public int Age
    {
        get => _childAge;

    }

    public Parent? Father
    {
        get => _childFather!;
    }
    public Parent? Mother
    {
        get => _childMother!;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Child's Name: {_childName}");
        Console.WriteLine($"Child's Age: {_childAge}");
        Console.WriteLine($"Child's Father: {_childFather!.Name}");
        Console.WriteLine($"Child's Mother: {_childMother!.Name}");
        Console.WriteLine();
    }

    public int GetParentsAge()
    {
        return Father!.Age + Mother!.Age;
    }

    public int GetProfit()
    {
        return Father!.Salary + Mother!.Salary;
    }

    public int GetFatherSalary()
    {
        return Father!.Salary;
    }
    public int GetMotherSalary()
    {
        return Mother!.Salary;
    }

    




}