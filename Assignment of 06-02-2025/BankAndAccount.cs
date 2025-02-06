using System;
using System.Collections.Generic;
class Bank {
    public string Name { get; set; }
    private List<Customer> customers = new List<Customer>();
    public Bank(string name) {
        Name = name;
    }
    public void OpenAccount(Customer customer, string accountNumber, decimal initialDeposit) {
        BankAccount newAccount = new BankAccount(accountNumber, initialDeposit, this);
        customer.AddAccount(newAccount);
        if (!customers.Contains(customer)) {
            customers.Add(customer);
        }
        Console.WriteLine("Account " + accountNumber + " opened for " + customer.Name + " at " + Name);
    }
}
class BankAccount {
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    public Bank Bank { get; }
    public BankAccount(string accountNumber, decimal initialDeposit, Bank bank) {
        AccountNumber = accountNumber;
        Balance = initialDeposit;
        Bank = bank;
    }
    public void Deposit(decimal amount) {
        Balance += amount;
    }
    public void Withdraw(decimal amount) {
        if (amount <= Balance) {
            Balance -= amount;
        } else {
            Console.WriteLine("not sufficient balance");
        }
    }
    public decimal GetBalance() {
        return Balance;
    }
}
class Customer {
    public string Name { get; set; }
    private List<BankAccount> accounts = new List<BankAccount>();
    public Customer(string name) {
        Name = name;
    }
    public void AddAccount(BankAccount account) {
        accounts.Add(account);
    }
    public void ViewBalance() {
        Console.WriteLine(Name + "'s Accounts:");
        foreach (var account in accounts) {
            Console.WriteLine("Account: " + account.AccountNumber + ", Balance: " + account.GetBalance() + ", Bank: " + account.Bank.Name);
        }
    }
}
class Program {
    static void Main() {
        Bank bank = new Bank("AXis Bank");
        Customer customer = new Customer("Aryan");
        
        bank.OpenAccount(customer, "166852456", 26200);
        bank.OpenAccount(customer, "7546189012", 78200);
        
        customer.ViewBalance();
    }
}
