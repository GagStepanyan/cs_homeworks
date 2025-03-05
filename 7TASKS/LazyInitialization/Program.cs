/*

Task 1: Property with Lazy Initialization and Read-Only Constraint
Task: Create a Person class with the following:
1. FirstName and LastName as auto-properties.
2. A read-only property FullName that is computed only once when accessed for the first time (lazy initialization).
3. Ensure FullName is stored internally and does not change if FirstName or LastName are modified.


*/

class Person {
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    private string? _personFullName;

    public string FullName {
        get { 
            if (_personFullName == null) {
                _personFullName = $"{FirstName} {LastName}";
            }
            return _personFullName!;
         }
    }

}

class Program {
    static void Main(string[] args) {
        Person person = new Person();
        person.FirstName = "Karen";
        person.LastName = "Babayan";
        Console.WriteLine(person.FullName);
    }
}