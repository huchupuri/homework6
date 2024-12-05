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
            Task3();
            Task4();
        }
        static void Task1()
        {
            Console.WriteLine("\nзадание 1");
//            Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
//банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
//доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
//вывести информацию об объекте класса на печать.
            List<BankAccount> accounts = new List<BankAccount>()
            {
                new BankAccount(132413, 4325000.75m, AccountType.savings),
                new BankAccount(51421, 230.75m, AccountType.credit),
                new BankAccount(13413, 1.24m, AccountType.savings)
            };
            foreach (BankAccount account in accounts)
            {
                account.PrintAccountInfo();
            }

                accounts[0].SetAccountType(AccountType.credit);
            accounts[1].SetBalance(0);
            accounts[2].SetID(123);

            
        }
//    Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
//номер счета генерировался сам и был уникальным.Для этого надо создать в классе
//статическую переменную и метод, который увеличивает значение этого переменной.
        static void Task2()
        {
            Console.WriteLine("\nзадание 2");
            List<BankAccount> accounts = new List<BankAccount>()
            {
                new BankAccount(4325000.75m, AccountType.savings),
                new BankAccount(230.75m, AccountType.credit),
                new BankAccount(124m, AccountType.savings)
            };

            foreach (BankAccount account in accounts)
            {
                account.PrintAccountInfo();
            }
        }

//        Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
//счет.Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
//положительного результата изменяет баланс.
        static void Task3()
        {
            Console.WriteLine("\nзадание 3");
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

//        Домашнее задание 7.1 Реализовать класс для описания здания(уникальный номер здания,
//        высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
//предусмотреть методы для заполнения полей и получения значений полей для печати.
//Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
//квартир на этаже и т.д.Предусмотреть возможность, чтобы уникальный номер здания
//генерировался программно.Для этого в классе предусмотреть статическое поле, которое бы
//хранило последний использованный номер здания, и предусмотреть метод, который
//увеличивал бы значение этого поля.
        static void Task4()
        {
            Console.WriteLine("\nзадание 4");
            Building buildingA = new Building(30, 10, 40, 2);
            buildingA.PrintInfo();
            
            Building anotherBuilding = new Building(45, 15, 60, 3);
            anotherBuilding.PrintInfo();
        }
    }
}