using System;
public class BankAccount{
    public int accountNumber;
    protected string accountHolder;
    private double balance;
    public void Deposit(double amount){
        balance += amount;
    }
    public void Withdraw(double amount){
        balance -= amount;
    }
    public double GetBalance(){
        return balance;
    }
}
public class SavingsAccount : BankAccount{
    public void DisplayAccountDetails(){
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
    }
}
