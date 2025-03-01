/*

Task 6: Employee Payroll System
Task: Create an Employee class with:
1. Name, Position, SalaryPerHour, and HoursWorked.
2. A method CalculateSalary() that returns SalaryPerHour * HoursWorked.
3. In Main(), create 3 employees, calculate their salaries, and display them.
4. If an employee works over 40 hours, pay overtime (1.5x rate).


*/


using System;

class Employee {
    
    private string? _employeeName;
    public string Name
    {
        get { return _employeeName!; }
        set { _employeeName = value; }
    }

    private string? _employeePosition;
    public string Position
    {
        get { return _employeePosition!; }
        set { _employeePosition = value; }
    }

    private double _employeeSalaryPerHour;
    public double SalaryPerHour 
    {
        get { return _employeeSalaryPerHour!; }
        set { _employeeSalaryPerHour = value; }
    }

    private double _employeeHoursWorked;
    public double HoursWorked 
    {
        get { return _employeeHoursWorked!; }
        set { _employeeHoursWorked = value; }
    }


    

    public Employee (string name, string position, double salaryPerHour, double hoursWorked)
     {
        _employeeName = name;
        _employeePosition = position;
        _employeeSalaryPerHour = salaryPerHour;
        _employeeHoursWorked = hoursWorked;
    }
    public static Employee create() {
        Console.WriteLine("enter the name");
        string? name = Console.ReadLine();
        Console.WriteLine("enter the position");
        string? position = Console.ReadLine();
        Console.WriteLine("enter the Salary Per Hour");
        double salaryPerHour = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the Hours already Worked");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());
        return new Employee(name!, position!, salaryPerHour, hoursWorked);
    }

    public double CalculateSalary() {
        if (_employeeHoursWorked > 40) {
            return ((_employeeSalaryPerHour * _employeeHoursWorked) * 1.5);
        }
        return _employeeSalaryPerHour * _employeeHoursWorked;
    }

    public void ShowInfo() {
        Console.WriteLine();
        Console.WriteLine($"Name: {_employeeName}");
        Console.WriteLine($"Position: {_employeePosition}");
        Console.WriteLine($"SalaryPerHour: {_employeeSalaryPerHour}");
        Console.WriteLine($"HoursWorked: {_employeeHoursWorked}");
        Console.WriteLine();
    }


}

class Program {
    static void Main(string[] args) {
       
        Employee[] employees = new Employee[3];
        for (int i = 0; i < employees.Length; ++i) {
            employees[i] = Employee.create();
            Console.Write($"your current salary: ${employees[i].CalculateSalary()}\n");            
        }

        
    }
}