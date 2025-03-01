/*

Task 5: Online Shopping Cart
Task: Create a Product class with:
1. Name, Price, and Quantity.
2. A method TotalPrice() that returns Price * Quantity.
3. In Main(), allow the user to add multiple products to a shopping cart and calculate the total cost.
4. If more than 5 items are purchased, apply a 10% discount.

*/

using System;

class Product {
    string? _productName;
    double _productPrice;
    int _productQuantity;

    public string Name {
        get { return _productName!; }
        set { _productName = value; }
    }

    public double Price {
        get { return _productPrice; }
        set { _productPrice = value; }
    }

    public int Quantity {
        get { return _productQuantity; }
        set { _productQuantity = value; }
    }

    public Product() {
        Console.Write("enter product's name: ");
        _productName = Console.ReadLine();
        Console.Write("enter product's price: ");
        _productPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("enter product's quantity: ");
        _productQuantity = Convert.ToInt32(Console.ReadLine());
    }

    public double TotalPrice() {
        if (_productQuantity >= 5) {
            return ((_productPrice * _productQuantity) * 90) / 100;
        }
        return _productPrice * _productQuantity;
    }

    
    public static void Run() {
        string? answ;
        while (true) {
            Console.WriteLine("Enter '+' to add a product");
            Console.WriteLine("Enter 'q' to exit");
            answ = Console.ReadLine();
            if (answ == "+") {
                Product product = new Product();
                Console.WriteLine("Total Price: " + product.TotalPrice());
            } else if (answ == "q" || answ == "Q") {
                break;
            }
        }
    }

}

class Program {
    static void Main(string[] args) {
        
    }
}

