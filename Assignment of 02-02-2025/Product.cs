using System;
public class Product{
    private string productName;
    private double price;
    public static int totalProducts = 0;
    public Product(string name, double pr){
        productName = name;
        price = pr;
        totalProducts++;
    }
    public void DisplayProductDetails(){
        Console.WriteLine("product Name : " + productName);
        Console.WriteLine("price : " + price);
    }
    public static void DisplayTotalProducts(){
        Console.WriteLine("products Created : " + totalProducts);
    }
}
