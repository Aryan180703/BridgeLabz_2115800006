using System;
using System.Collections.Generic;

abstract class BankAccount {
    private int accountNumber;
    private string holderName;
    private double balance;

    public int AccountNumber {
        get { return accountNumber; }
        private set { accountNumber = value; }
    }
    public string HolderName {
        get { return holderName; }
        private set { holderName = value; }
    }
    public double Balance {
        get { return balance; }
        protected set { balance = value; }
    }

    protected BankAccount(int accountNumber, string holderName, double balance) {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }

    public void Deposit(double amount) {
        if (amount > 0) {
            Balance += amount;
            Console.WriteLine("Deposit Successful!");
        } else {
            Console.WriteLine("Invalid deposit amount!");
        }
        Console.WriteLine();
    }

    public virtual void Withdraw(double amount) {
        if (amount > 0 && amount <= Balance) {
            Balance -= amount;
            Console.WriteLine("Withdrawal Successful!");
        } else {
            Console.WriteLine("Insufficient funds or invalid amount!");
        }
        Console.WriteLine();
    }

    public abstract double CalculateInterest();

    public virtual void DisplayDetails() {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Holder Name: " + HolderName);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine();
    }
}

interface ILoanable {
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

class SavingsAccount : BankAccount, ILoanable {
    public SavingsAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest() {
        return Balance * 0.04;
    }

    public void ApplyForLoan() {
        Console.WriteLine("Loan Application Processed for Savings Account.");
        Console.WriteLine();
    }

    public double CalculateLoanEligibility() {
        return Balance * 2;
    }

    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Account Type: Savings");
        Console.WriteLine();
    }
}

class CurrentAccount : BankAccount {
    public CurrentAccount(int accountNumber, string holderName, double balance)
        : base(accountNumber, holderName, balance) { }

    public override double CalculateInterest() {
        return 0;
    }

    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Account Type: Current");
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        List<BankAccount> accounts = new List<BankAccount>();

        while (true) {
            Console.WriteLine("1. Open Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Calculate Interest");
            Console.WriteLine("5. Apply for Loan");
            Console.WriteLine("6. Display Account Details");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    Console.WriteLine("1. Savings Account");
                    Console.WriteLine("2. Current Account");
                    Console.Write("Enter account type: ");
                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter account number: ");
                    int accNum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter holder name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter initial balance: ");
                    double balance = Convert.ToDouble(Console.ReadLine());

                    if (type == 1) {
                        accounts.Add(new SavingsAccount(accNum, name, balance));
                    } else if (type == 2) {
                        accounts.Add(new CurrentAccount(accNum, name, balance));
                    }

                    Console.WriteLine("Account Created Successfully!");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Enter account number: ");
                    int depositAcc = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter deposit amount: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());

                    foreach (var acc in accounts) {
                        if (acc.AccountNumber == depositAcc) {
                            acc.Deposit(depositAmount);
                            break;
                        }
                    }
                    break;

                case 3:
                    Console.Write("Enter account number: ");
                    int withdrawAcc = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter withdrawal amount: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                    foreach (var acc in accounts) {
                        if (acc.AccountNumber == withdrawAcc) {
                            acc.Withdraw(withdrawAmount);
                            break;
                        }
                    }
                    break;

                case 4:
                    Console.Write("Enter account number: ");
                    int interestAcc = Convert.ToInt32(Console.ReadLine());

                    foreach (var acc in accounts) {
                        if (acc.AccountNumber == interestAcc) {
                            Console.WriteLine("Interest: " + acc.CalculateInterest());
                            Console.WriteLine();
                            break;
                        }
                    }
                    break;

                case 5:
                    Console.Write("Enter account number: ");
                    int loanAcc = Convert.ToInt32(Console.ReadLine());

                    foreach (var acc in accounts) {
                        if (acc.AccountNumber == loanAcc && acc is ILoanable) {
                            ILoanable loanableAcc = (ILoanable)acc;
                            loanableAcc.ApplyForLoan();
                            Console.WriteLine("Loan Eligibility: " + loanableAcc.CalculateLoanEligibility());
                            Console.WriteLine();
                            break;
                        }
                    }
                    break;

                case 6:
                    foreach (var acc in accounts) {
                        acc.DisplayDetails();
                    }
                    break;

                case 7:
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
