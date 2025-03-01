/*

Task 8: E-Commerce Product System
Task: Create a class Product with:
1. Fields name, price, and stockQuantity.
2. Add a constructor that uses this to differentiate between parameters and fields.
3. In Main(), create a product and display its details.

*/

class Product {
    string? name;
    double price;
    int stockQuantity;

    public Product(string name, double price, int stockQuantity) {
        this.name = name;
        this.price = price;
        this.stockQuantity = stockQuantity;
    }

    public void DisplayInfo() {
        Console.WriteLine("\nProduct info");
        Console.WriteLine($"Name: {this.name}");
        Console.WriteLine($"Price: ${this.price}.00");
        Console.WriteLine($"Stock Quantity: {this.stockQuantity}");
        Console.WriteLine();
    }
}

class Program {
    static void Main(string[] args) {
        Product product = new Product("The Macallan", 150, 15);
        product.DisplayInfo();
    }
}