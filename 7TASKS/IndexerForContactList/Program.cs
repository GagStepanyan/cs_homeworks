/*

    Read-Only Indexer for Contact List
Task: Create a ContactArray class that:
1. Stores contacts as Person objects.
2. Allows searching contacts by ID or Name using two separate indexers.
3. Returns null if no contact is found.

*/

class Person {
    string? _personName;
    int _personId;
    
    public string Name {
        get { return _personName!; }
        set { _personName = value; }
    }

    public int Id {
        get { return _personId; }
        set { _personId = value; }
    }

    public Person(int personId, string? personName) {
        _personName = personName;
        _personId = personId;
    }
}
class ContactArray {
    Person[] _contacts;
    public ContactArray(Person[] people) {
        _contacts = people;
    }   

    public Person this[int id] {
        get {
            if (_contacts == null) {
                return null!;
            }
            foreach (Person person in _contacts) {
                if (person != null && person.Id == id) {
                    return person;
                }
            }
            return null!;
        }
    }

    public Person this[string name] {
        get {
            if (_contacts == null) {
                return null!;
            } 
            foreach (Person person in _contacts) {
                if (person != null && person.Name == name) {
                    return person;
                }
            }
            return null!;
        }
    }

}

class Program {
    static void Main(string[] args) {
        Person[] people = new Person[3];

        people[0] = new Person(1, "Alice");
        people[1] = new Person(2, "Bob");
        people[2] = new Person(3, "Charlie");

            ContactArray contactList = new ContactArray(people);

            Person alice = contactList["Alice"];
            Person bob = contactList[2];
            Person dave = contactList["Dave"];
            Person four = contactList[4];

            Console.WriteLine($"Alice: {(alice != null ? alice.Name : "Not found")}");
            Console.WriteLine($"Bob: {(bob != null ? bob.Name : "Not found")}");
            Console.WriteLine($"Dave: {(dave != null ? (dave.Name) : "Not found")}");
            Console.WriteLine($"4: {(four != null ? (four.Name) : "Not found")}");
    }
}