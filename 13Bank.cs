using System;

class Bank
{
    public static double InterestRate { get; private set; } = 5.0; 

    public string AccountHolder;
    public double Balance;

    public Bank(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public static void SetInterestRate(double rate)
    {
        InterestRate = rate;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
    }
}
