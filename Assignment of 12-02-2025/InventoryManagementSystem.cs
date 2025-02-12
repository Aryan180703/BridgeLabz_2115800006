using System;

public class InventoryItem {
    public string ItemName { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public InventoryItem Next { get; set; }

    public InventoryItem(string itemName, int itemID, int quantity, double price) {
        ItemName = itemName;
        ItemID = itemID;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

public class InventoryManagement {
    private InventoryItem Head;

    public void AddItemAtStart(InventoryItem item) {
        item.Next = Head;
        Head = item;
    }

    public void AddItemAtEnd(InventoryItem item) {
        if (Head == null) {
            Head = item;
            return;
        }
        InventoryItem temp = Head;
        while (temp.Next != null) {
            temp = temp.Next;
        }
        temp.Next = item;
    }

    public void AddItemAtPosition(InventoryItem item, int position) {
        if (position == 1) {
            AddItemAtStart(item);
            return;
        }
        InventoryItem temp = Head;
        int count = 1;
        while (temp != null && count < position - 1) {
            temp = temp.Next;
            count++;
        }
        if (temp == null) {
            AddItemAtEnd(item);
        } else {
            item.Next = temp.Next;
            temp.Next = item;
        }
    }

    public void RemoveItemByID(int itemID) {
        if (Head == null) {
            Console.WriteLine("Inventory is empty.");
            return;
        }
        if (Head.ItemID == itemID) {
            Head = Head.Next;
            Console.WriteLine("Item removed successfully.");
            return;
        }
        InventoryItem temp = Head;
        while (temp.Next != null && temp.Next.ItemID != itemID) {
            temp = temp.Next;
        }
        if (temp.Next == null) {
            Console.WriteLine("Item not found.");
        } else {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed successfully.");
        }
    }

    public void UpdateQuantity(int itemID, int newQuantity) {
        InventoryItem temp = Head;
        while (temp != null) {
            if (temp.ItemID == itemID) {
                temp.Quantity = newQuantity;
                Console.WriteLine("Quantity updated successfully.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchItemByID(int itemID) {
        InventoryItem temp = Head;
        while (temp != null) {
            if (temp.ItemID == itemID) {
                Console.WriteLine("Item Name: " + temp.ItemName);
                Console.WriteLine("Item ID: " + temp.ItemID);
                Console.WriteLine("Quantity: " + temp.Quantity);
                Console.WriteLine("Price: " + temp.Price);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchItemByName(string itemName) {
        InventoryItem temp = Head;
        while (temp != null) {
            if (temp.ItemName == itemName) {
                Console.WriteLine("Item ID: " + temp.ItemID);
                Console.WriteLine("Quantity: " + temp.Quantity);
                Console.WriteLine("Price: " + temp.Price);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void CalculateTotalInventoryValue() {
        double totalValue = 0;
        InventoryItem temp = Head;
        while (temp != null) {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + totalValue);
    }

    public void DisplayInventory() {
        InventoryItem temp = Head;
        while (temp != null) {
            Console.WriteLine("Item Name: " + temp.ItemName);
            Console.WriteLine("Item ID: " + temp.ItemID);
            Console.WriteLine("Quantity: " + temp.Quantity);
            Console.WriteLine("Price: " + temp.Price);
            Console.WriteLine();
            temp = temp.Next;
        }
    }

    public static void Main(string[] args) {
        InventoryManagement inventory = new InventoryManagement();
        while (true) {
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Update Quantity");
            Console.WriteLine("4. Search Item by ID");
            Console.WriteLine("5. Search Item by Name");
            Console.WriteLine("6. Calculate Total Inventory Value");
            Console.WriteLine("7. Display Inventory");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.Write("Enter Item Name: ");
                    string itemName = Console.ReadLine();
                    Console.Write("Enter Item ID: ");
                    int itemID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Where to add item?");
                    Console.WriteLine("1. At Beginning");
                    Console.WriteLine("2. At End");
                    Console.WriteLine("3. At a specific position");
                    int position = Convert.ToInt32(Console.ReadLine());
                    if (position == 1)
                        inventory.AddItemAtStart(new InventoryItem(itemName, itemID, quantity, price));
                    else if (position == 2)
                        inventory.AddItemAtEnd(new InventoryItem(itemName, itemID, quantity, price));
                    else {
                        Console.Write("Enter position: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        inventory.AddItemAtPosition(new InventoryItem(itemName, itemID, quantity, price), pos);
                    }
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
