using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    // Constructor
    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    // Method to deposit money
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    // Method to withdraw money
    public void Withdraw(decimal amount)
    {
        balance -= amount;
    }

    // Method to display the balance
    public void DisplayBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }
}

class Result
{
    static void Main()
    {
        // Create an instance of BankAccount
        BankAccount myAccount = new BankAccount("123456789");

        // Perform deposit and withdraw
        myAccount.Deposit(1000);
        myAccount.Withdraw(500);

        // Print out the final balance
        myAccount.DisplayBalance();
    }
}
