/*

Task 1: Phone Book
Task: Create a Contact class with:
1. Name, PhoneNumber, and Email properties.
2. A method DisplayInfo() to print contact details.
3. A Main() method where the user can create 3 contacts and display them.
4. Store contacts in an array and allow searching by name.

*/

using System;

class Contact {
    private string? _userName;
    private string? _userEmail;
    private string? _userPhone;

    public string UserName 
    { 
        get { return _userName!;}
        set {_userName = value;}    
    }

    public string UserEmail 
    { 
        get { return _userEmail!;}
        set {_userEmail = value;}    
    }

    public string UserPhone 
    { 
        get { return _userPhone!;}
        set {_userPhone = value;}    
    }

    

    public Contact(string name, string email, string phone) {
        _userName = name;
        _userEmail = email; 
        _userPhone = phone;
    }

   public void DisplayInfo() {
        Console.WriteLine();
        Console.WriteLine($"name: {_userName}\nemail: {_userEmail}\nPhone: {_userPhone}\n");
        Console.WriteLine();
    }

}



class Program {
    static void Main(string[] args) {
        int count = 0;
        Console.WriteLine("how many contacts do you want");
        count = Convert.ToInt32(Console.ReadLine());
        Contact[] contacts = new Contact[count];

        string? name;
        string? phone;
        string? email;

        for (int i = 0; i < count; ++i) {
            Console.WriteLine("enter a name");
            name = Console.ReadLine();
            
            Console.WriteLine("enter a phone");
            phone = Console.ReadLine();
            
            Console.WriteLine("enter a email");
            email = Console.ReadLine();
            
            contacts[i] = new Contact(name!, email!, phone!);
        }

        for (int i = 0; i < count; ++i) {
            contacts[i].DisplayInfo();
        }

        // Search by name

        Console.WriteLine("enter a contacts Name");
        string? searched = Console.ReadLine();

        for (int i = 0; i < contacts.Length; ++i) {
            if (contacts[i].UserName.Equals(searched)) {
                Console.WriteLine("Contact found!\n");
                contacts[i].DisplayInfo();
                break;
            }
            
            if (i == contacts.Length - 1) {
                Console.WriteLine("the contact was not found...");
            }
        }
    }
}