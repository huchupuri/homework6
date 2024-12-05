using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTheme
{
    abstract class PawnShopItem
    {
        private static int lastId = 1; 
        private int id; 
        public string name { get; set; } 
        public decimal marketValue { get; set; } 
        public decimal loanValue { get; private set; } 
        public bool isRedeemed { get; private set; } 

        /// <summary>
        /// конструктор товара
        /// </summary>
        public PawnShopItem(string name, decimal marketValue, decimal loanValue)
        {
            id = GenerateId();
            this.name = name;
            this.marketValue = marketValue;
            this.loanValue = loanValue;
            this.isRedeemed = false;
        }

        /// <summary>
        /// генерация нового id
        /// </summary>
        private static int GenerateId()
        {
            return lastId++; // Увеличивает и возвращает новый уникальный ID
        }

        /// <summary>
        /// метод описания товара
        /// </summary>
        public abstract string GetDescription(); 

        /// <summary>
        /// метод для выкупа товара
        /// </summary>
        public void Redeem()
        {
            isRedeemed = true;
            Console.WriteLine($"{name} выкуплен.");
        }

        /// <summary>
        /// обновление стоимости
        /// </summary>
        public void UpdateLoanValue(decimal newLoanValue)
        {
            loanValue = newLoanValue;
            Console.WriteLine($"Сумма займа для {name} обновлена до {loanValue}");
        }



        /// <summary>
        /// вывод информации
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"ID: {id}, Название: {name}, Рыночная стоимость: {marketValue}, Сумма займа: {loanValue}, Выкуплен: {isRedeemed}");
        }
    }
}
