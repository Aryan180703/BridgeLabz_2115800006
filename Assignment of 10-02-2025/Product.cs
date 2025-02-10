using System;
using System.Collections.Generic;

abstract class Product {
    private int productId;
    private string name;
    private double price;

    public int ProductId {
        get { return productId; }
        private set { productId = value; }
    }
    public string Name {
        get { return name; }
        private set { name = value; }
    }
    public double Price {
        get { return price; }
        private set { price = value; }
    }

    protected Product(int productId, string name, double price) {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public virtual void DisplayDetails() {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }
}

interface ITaxable {
    double CalculateTax();
    string GetTaxDetails();
}

class Electronics : Product, ITaxable {
    public Electronics(int productId, string name, double price) : base(productId, name, price) {}
    
    public override double CalculateDiscount() {
        return Price * 0.1;
    }
    
    public double CalculateTax() {
        return Price * 0.18;
    }
    
    public string GetTaxDetails() {
        return "18% GST applies.";
    }
    
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Discount: " + CalculateDiscount());
        Console.WriteLine("Tax: " + CalculateTax());
        Console.WriteLine("Final Price: " + (Price + CalculateTax() - CalculateDiscount()));
    }
}

class Clothing : Product {
    public Clothing(int productId, string name, double price) : base(productId, name, price) {}
    
    public override double CalculateDiscount() {
        return Price * 0.2;
    }
    
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Discount: " + CalculateDiscount());
        Console.WriteLine("Final Price: " + (Price - CalculateDiscount()));
    }
}

class Groceries : Product {
    public Groceries(int productId, string name, double price) : base(productId, name, price) {}
    
    public override double CalculateDiscount() {
        return Price * 0.05;
    }
    
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Discount: " + CalculateDiscount());
        Console.WriteLine("Final Price: " + (Price - CalculateDiscount()));
    }
}

class Program {
    static void Main(string[] args) {
        List<Product> products = new List<Product>();
        while (true) {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            switch (choice) {
                case 1:
                    Console.WriteLine("Select Product Type:");
                    Console.WriteLine("1. Electronics");
                    Console.WriteLine("2. Clothing");
                    Console.WriteLine("3. Groceries");
                    Console.Write("Enter choice: ");
                    int productType = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    
                    Console.Write("Enter Product ID: ");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    
                    switch (productType) {
                        case 1:
                            products.Add(new Electronics(productId, name, price));
                            break;
                        case 2:
                            products.Add(new Clothing(productId, name, price));
                            break;
                        case 3:
                            products.Add(new Groceries(productId, name, price));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    Console.WriteLine();
                    break;
                
                case 2:
                    foreach (var product in products) {
                        product.DisplayDetails();
                        Console.WriteLine();
                    }
                    break;
                
                case 3:
                    return;
                
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
