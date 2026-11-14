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

    public void Transfer(BankAccount account,double sum)
    {
        if (sum <= account.balance && sum > 0)
        {
            account.balance -= sum;
            balance += sum;
            Console.WriteLine("Перевод выполнен");
        }
        else
        {
            Console.WriteLine("Перевод невозможен");
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
        BankAccount account1 = new BankAccount();
        BankAccount account2 = new BankAccount();

        account1.SetData(10000, AccountType.Текущий);
        account2.SetData(5000, AccountType.Сберегательный);

        account2.Transfer(account1, 3000);

        Console.WriteLine("Первый счет: ");
        account1.ShowData();
        Console.WriteLine("Второй счет: ");
        account2.ShowData();
    }
}