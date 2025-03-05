/*

 Property with Validation and Default Value
Task: Create a Product class that contains:
1. A Price property that:
    Cannot be negative.
    If set to a negative value, defaults to 0.
2. A Stock property that:
    Cannot be negative.
    If set to a negative value, defaults to 10.

*/

class Product {
    private double _productPrice;
    private int _productStock;

    public double Price {
        get {return _productPrice;}
        set { _productPrice = value >= 0 ? value : 0;}
    }

    public int Stock {
        get {return _productStock;}
        set {_productStock = value >= 0 ? value : 10;}
    }

    public Product(double price, int stock) {
        Price = price;
        Stock = stock;
    }

    public void Display(){
        Console.WriteLine();
        Console.WriteLine($"Price: {_productPrice}");
        Console.WriteLine($"Stock: {_productStock}");
        Console.WriteLine();
    }

}

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Tetsing Valid intputs");
        Product product1 = new Product(100, 10);
        Product product2 = new Product(150, 15);
        Product product3 = new Product(300, 25);

        Console.WriteLine("Tetsing InValid intputs");
        Product product4 = new Product(-10, 0);
        Product product5 = new Product(-1, -1);

        product1.Display();
        product2.Display();
        product3.Display();
        product4.Display();
        product5.Display();
    }
}