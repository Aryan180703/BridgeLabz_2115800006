using System;
using System.Collections.Generic;
class ShoppingCart{
    private Dictionary<string, double> productPrices;
    private LinkedList<string> productOrder;
    private SortedDictionary<double, List<string>> sortedProducts;
    public ShoppingCart(){
        productPrices = new Dictionary<string, double>();
        productOrder = new LinkedList<string>();
        sortedProducts = new SortedDictionary<double, List<string>>();
    }
    public void AddProduct(string product, double price){
        if (!productPrices.ContainsKey(product)){
            productPrices[product] = price;
            productOrder.AddLast(product);
            if (!sortedProducts.ContainsKey(price)){
                sortedProducts[price] = new List<string>();
            }
            sortedProducts[price].Add(product);
        }
    }

    public void DisplayProducts(){
        Console.WriteLine("Products in Cart:");
        foreach (string product in productOrder){
            Console.WriteLine(product + " - " + productPrices[product]);
        }
    }

    public void DisplaySortedProducts(){
        Console.WriteLine("Products Sorted by Price:");
        foreach (KeyValuePair<double, List<string>> entry in sortedProducts){
            foreach (string product in entry.Value){
                Console.WriteLine(product + " - " + entry.Key);
            }
        }
    }
}

class Program{
    static void Main(){
        ShoppingCart cart = new ShoppingCart();

        cart.AddProduct("Laptop", 10000);
        cart.AddProduct("Mouse", 150);
        cart.AddProduct("Keyboard", 400);
        cart.AddProduct("Monitor", 2000);

        cart.DisplayProducts();
        cart.DisplaySortedProducts();
    }
}
