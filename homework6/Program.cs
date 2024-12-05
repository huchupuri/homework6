using homework6;
using System;
using System.Diagnostics;
using System.Security.Principal;

namespace laba
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            List<BankAccount> accounts = new List<BankAccount>()
            {
                new BankAccount(4325000.75m, AccountType.savings),
                new BankAccount(230.75m, AccountType.credit),
                new BankAccount(1,124m, AccountType.savings)
            };
            accounts[0].SetAccountType(AccountType.credit);
            accounts[1].SetBalance(0);
            accounts[2].SetID(123);
            foreach (BankAccount account in accounts)
            {
                if (account.WithdrawCash(1000m))
                {
                    Console.WriteLine($"остаточный счет: {account.GetBalance():N}");
                }
                else Console.WriteLine($"на аккаунте {account.GetID()} недостаточно средств");
                account.Deposit(10000m);
                account.PrintAccountInfo();
            }
        }
        static void Task2()
        {
            Building buildingA = new Building(30, 10, 40, 2);
            buildingA.PrintInfo();
            
            Building anotherBuilding = new Building(45, 15, 60, 3);
            anotherBuilding.PrintInfo();
        }
    }
}