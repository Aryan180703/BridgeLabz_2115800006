using System;
using System.Collections.Generic;

abstract class FoodItem {
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName {
        get { return itemName; }
        private set { itemName = value; }
    }

    public double Price {
        get { return price; }
        private set { price = value; }
    }

    public int Quantity {
        get { return quantity; }
        private set { quantity = value; }
    }

    protected FoodItem(string itemName, double price, int quantity) {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    public virtual void GetItemDetails() {
        Console.WriteLine("Item Name: " + ItemName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
        Console.WriteLine();
    }

    public abstract double CalculateTotalPrice();
}

interface IDiscountable {
    void ApplyDiscount(double percentage);
    void GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable {
    private double discount;

    public VegItem(string itemName, double price, int quantity) 
        : base(itemName, price, quantity) {
        discount = 0;
    }

    public override double CalculateTotalPrice() {
        double total = Price * Quantity;
        return total - (total * discount / 100);
    }

    public void ApplyDiscount(double percentage) {
        discount = percentage;
        Console.WriteLine("Discount of " + percentage + "% Applied to " + ItemName);
        Console.WriteLine();
    }

    public void GetDiscountDetails() {
        Console.WriteLine("Discount: " + discount + "%");
        Console.WriteLine();
    }
}

class NonVegItem : FoodItem, IDiscountable {
    private double discount;
    private const double additionalCharge = 2.50; 

    public NonVegItem(string itemName, double price, int quantity) 
        : base(itemName, price, quantity) {
        discount = 0;
    }

    public override double CalculateTotalPrice() {
        double total = (Price + additionalCharge) * Quantity;
        return total - (total * discount / 100);
    }

    public void ApplyDiscount(double percentage) {
        discount = percentage;
        Console.WriteLine("Discount of " + percentage + "% Applied to " + ItemName);
        Console.WriteLine();
    }

    public void GetDiscountDetails() {
        Console.WriteLine("Discount : " + discount + "%");
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        List<FoodItem> foodItems = new List<FoodItem>();

        while (true) {
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Display Food Items");
            Console.WriteLine("3. Apply Discount");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    Console.WriteLine("1. Veg Item");
                    Console.WriteLine("2. Non-Veg Item");
                    Console.Write("Enter item type : ");
                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter item name : ");
                    string name = Console.ReadLine();

                    Console.Write("Enter price : ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter quantity : ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    if (type == 1) {
                        foodItems.Add(new VegItem(name, price, quantity));
                    } else if (type == 2) {
                        foodItems.Add(new NonVegItem(name, price, quantity));
                    }

                    Console.WriteLine("Food Item Added Successfully ");
                    Console.WriteLine();
                    break;

                case 2:
                    foreach (var item in foodItems) {
                        item.GetItemDetails();
                    }
                    break;

                case 3:
                    Console.Write("Enter item name for discount : ");
                    string discountName = Console.ReadLine();

                    Console.Write("Enter discount percentage : ");
                    double discountPercent = Convert.ToDouble(Console.ReadLine());

                    foreach (var item in foodItems) {
                        if (item.ItemName == discountName && item is IDiscountable) {
                            ((IDiscountable)item).ApplyDiscount(discountPercent);
                            break;
                        }
                    }
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
