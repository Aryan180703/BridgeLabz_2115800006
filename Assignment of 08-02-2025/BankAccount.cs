using System;

class BankAccount {
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public BankAccount(string accountNumber, double balance) {
        AccountNumber = accountNumber;
        Balance = balance;
    }
    public virtual void DisplayAccountType() {
        Console.WriteLine("General Bank Account ");
    }
}
class SavingsAccount : BankAccount {
    public double InterestRate { get; set; }
    public SavingsAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance) {
        InterestRate = interestRate;
    }
    public override void DisplayAccountType() {
        Console.WriteLine("Savings Account");
    }
}

class CheckingAccount : BankAccount {
    public double WithdrawalLimit { get; set; }
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance) {
        WithdrawalLimit = withdrawalLimit;
    }
    public override void DisplayAccountType() {
        Console.WriteLine("Checking Account");
    }
}

class FixedDepositAccount : BankAccount {
    public int MaturityPeriod { get; set; }
    public FixedDepositAccount(string accountNumber, double balance, int maturityPeriod) : base(accountNumber, balance) {
        MaturityPeriod = maturityPeriod;
    }
    public override void DisplayAccountType() {
        Console.WriteLine("Fixed Deposit Account");
    }
}
