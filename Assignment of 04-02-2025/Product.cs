using System;

class Product {
    private static double Discount = 0.0;
    private static int productCounter = 0;
    public readonly int ProductID;
    private string productName;
    private double price;
    private int quantity;
    public Product(string productName, double price, int quantity) {
        this.ProductID = ++productCounter;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }
    public string GetProductName() {
        return productName;
    }
    private void SetProductName(string productName) {
        this.productName = productName;
    }
    public double GetPrice() {
        return price;
    }
    private void SetPrice(double price) {
        this.price = price;
    }
    public int GetQuantity() {
        return quantity;
    }
    private void SetQuantity(int quantity) {
        this.quantity = quantity;
    }
    public static void UpdateDiscount(double newDiscount) {
        Discount = newDiscount;
    }
    public double GetDiscountedPrice() {
        return price - (price * Discount / 100);
    }
    public void DisplayProduct() {
        Console.WriteLine("Product ID: {0}", ProductID);
        Console.WriteLine("Product Name: {0}", productName);
        Console.WriteLine("Price: {0:C}", price);
        Console.WriteLine("Discounted Price: {0:C}", GetDiscountedPrice());
        Console.WriteLine("Quantity: {0}\n", quantity);
    }
    public static void ValidateProduct(object obj) {
        if (obj is Product product) {
            Console.WriteLine("The object is a valid Product instance.");
            product.DisplayProduct();
        }
        else {
            Console.WriteLine("Invalid Product object.");
        }
    }
}
class Program {
    static void Main() {
        Product p1 = new Product("Laptop", 150000, 2);
        Product p2 = new Product("Smartphone", 80000, 5);
        Product.UpdateDiscount(10);
        p1.DisplayProduct();
        p2.DisplayProduct();
        Product.ValidateProduct(p1);
        Product.ValidateProduct("Not a product");
    }
}