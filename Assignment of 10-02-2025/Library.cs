using System;
using System.Collections.Generic;

abstract class LibraryItem {
    private int itemId;
    private string title;
    private string author;
    private bool isReserved;

    public int ItemId {
        get { return itemId; }
        private set { itemId = value; }
    }

    public string Title {
        get { return title; }
        private set { title = value; }
    }

    public string Author {
        get { return author; }
        private set { author = value; }
    }

    public bool IsReserved {
        get { return isReserved; }
        private set { isReserved = value; }
    }

    protected LibraryItem(int itemId, string title, string author) {
        ItemId = itemId;
        Title = title;
        Author = author;
        IsReserved = false;
    }

    public virtual void GetItemDetails() {
        Console.WriteLine("Item ID: " + ItemId);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Reserved: " + (IsReserved ? "Yes" : "No"));
        Console.WriteLine();
    }

    public abstract int GetLoanDuration();

    public void ReserveItem() {
        if (!IsReserved) {
            IsReserved = true;
            Console.WriteLine("Item Reserved Successfully!");
        } else {
            Console.WriteLine("Item is Already Reserved!");
        }
        Console.WriteLine();
    }

    public bool CheckAvailability() {
        return !IsReserved;
    }
}

interface IReservable {
    void ReserveItem();
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable {
    public Book(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration() {
        return 14;
    }

    public override void GetItemDetails() {
        base.GetItemDetails();
        Console.WriteLine("Item Type: Book");
        Console.WriteLine();
    }
}

class Magazine : LibraryItem, IReservable {
    public Magazine(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration() {
        return 7;
    }

    public override void GetItemDetails() {
        base.GetItemDetails();
        Console.WriteLine("Item Type: Magazine");
        Console.WriteLine();
    }
}

class DVD : LibraryItem, IReservable {
    public DVD(int itemId, string title, string author)
        : base(itemId, title, author) { }

    public override int GetLoanDuration() {
        return 5;
    }

    public override void GetItemDetails() {
        base.GetItemDetails();
        Console.WriteLine("Item Type: DVD");
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        while (true) {
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Display Item Details");
            Console.WriteLine("3. Get Loan Duration");
            Console.WriteLine("4. Reserve Item");
            Console.WriteLine("5. Check Availability");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Magazine");
                    Console.WriteLine("3. DVD");
                    Console.Write("Enter item type: ");
                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter item ID: ");
                    int itemId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();

                    if (type == 1) {
                        libraryItems.Add(new Book(itemId, title, author));
                    } else if (type == 2) {
                        libraryItems.Add(new Magazine(itemId, title, author));
                    } else if (type == 3) {
                        libraryItems.Add(new DVD(itemId, title, author));
                    }

                    Console.WriteLine("Item Added Successfully!");
                    Console.WriteLine();
                    break;

                case 2:
                    foreach (var item in libraryItems) {
                        item.GetItemDetails();
                    }
                    break;

                case 3:
                    Console.Write("Enter item ID: ");
                    int loanId = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in libraryItems) {
                        if (item.ItemId == loanId) {
                            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
                            Console.WriteLine();
                            break;
                        }
                    }
                    break;

                case 4:
                    Console.Write("Enter item ID: ");
                    int reserveId = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in libraryItems) {
                        if (item.ItemId == reserveId && item is IReservable) {
                            item.ReserveItem();
                            break;
                        }
                    }
                    break;

                case 5:
                    Console.Write("Enter item ID: ");
                    int checkId = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in libraryItems) {
                        if (item.ItemId == checkId && item is IReservable) {
                            Console.WriteLine(item.CheckAvailability() ? "Item is Available" : "Item is Reserved");
                            Console.WriteLine();
                            break;
                        }
                    }
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
