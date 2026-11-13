using System;

enum AccountType
{
    Текущий,
    Сберегательный
}

class BankAccount
{
    private static int numberCounter = 0;

    private int number;
    private double balance;
    private AccountType type;

    public void SetData(double b, AccountType t)
    {
        numberCounter++;
        number = numberCounter;

        balance = b;
        type = t;
    }

    public void PutMoney(double sum)
    {
        balance += sum;
    }

    public void TakeMoney(double sum)
    {
        if (sum <= balance && sum > 0)
        {
            balance -= sum;
            Console.WriteLine("Деньги сняты");
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
        }
    }

    public void ShowData()
    {
        Console.WriteLine("Номер счета: " + number);
        Console.WriteLine("Баланс: " + balance);
        Console.WriteLine("Тип счета: " + type);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.SetData(10000, AccountType.Текущий);

        account.PutMoney(2000);
        account.TakeMoney(3000);

        account.ShowData();
    }
}
