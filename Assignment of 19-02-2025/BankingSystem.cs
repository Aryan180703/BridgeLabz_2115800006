using System;
using System.Collections.Generic;
class BankingSystem{
    private Dictionary<int, double> accountBalances;
    private SortedDictionary<double, List<int>> sortedAccounts;
    private Queue<int> withdrawalQueue;
    public BankingSystem(){
        accountBalances = new Dictionary<int, double>();
        sortedAccounts = new SortedDictionary<double, List<int>>();
        withdrawalQueue = new Queue<int>();
    }
    public void AddAccount(int accountNumber, double balance){
        if (!accountBalances.ContainsKey(accountNumber)){
            accountBalances[accountNumber] = balance;
            if (!sortedAccounts.ContainsKey(balance)){
                sortedAccounts[balance] = new List<int>();
            }
            sortedAccounts[balance].Add(accountNumber);
        }
    }
    public void RequestWithdrawal(int accountNumber){
        if (accountBalances.ContainsKey(accountNumber)){
            withdrawalQueue.Enqueue(accountNumber);
        }
    }

    public void ProcessWithdrawals(){
        Console.WriteLine("Processing Withdrawals :");
        while (withdrawalQueue.Count > 0){
            int accountNumber = withdrawalQueue.Dequeue();
            Console.WriteLine("Processed withdrawal for Account : " + accountNumber);
        }
    }

    public void DisplaySortedAccounts(){
        Console.WriteLine("Accounts Sorted by Balance:");
        foreach (KeyValuePair<double, List<int>> entry in sortedAccounts){
            foreach (int account in entry.Value){
                Console.WriteLine("Account: " + account + " - " + entry.Key);
            }
        }
    }
}

class Program{
    static void Main(){
        BankingSystem bank = new BankingSystem();
        bank.AddAccount(101, 9878);
        bank.AddAccount(102, 50765);
        bank.AddAccount(103, 250000);
        bank.AddAccount(104, 768799);
        bank.RequestWithdrawal(101);
        bank.RequestWithdrawal(103);        
        bank.DisplaySortedAccounts();
        bank.ProcessWithdrawals();
    }
}
