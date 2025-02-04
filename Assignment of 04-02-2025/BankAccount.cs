using System;
class BankAccount{
    public static string bankName = "Axis";
    private static int totalAccounts = 0;
    public readonly int AccountNumber;
    public string AccountHolderName;
    public double Balance;
    public BankAccount(string accountHolderName, int accountNumber, double initialBalance){
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        this.Balance = initialBalance;
        totalAccounts++; 
    }
    public static void GetTotalAccounts(){
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }
    public void DisplayAccountDetails() {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: $" + Balance);
        }
        else{
            Console.WriteLine("Invalid account.");
        }
    }

    public static void Main(string[] args){
        BankAccount acc1 = new BankAccount("Aryan", 70075655432, 70007);
        BankAccount acc2 = new BankAccount("Dhruv", 64674535435, 20054);
        acc1.DisplayAccountDetails();
        Console.WriteLine();
        acc2.DisplayAccountDetails(); 
        GetTotalAccounts();
    }
}
