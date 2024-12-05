﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myTheme
{
    /// <summary>
    /// техника
    /// </summary>
    class PawnShopTechnique : PawnShopItem
    {
        public string brand { get; set; } 
        private string model { get; set; } 
        public string condition { get; set; }

        // Первый конструктор
        public PawnShopTechnique(string name, decimal marketValue, decimal loanValue, string brand, string model, string condition)
            : base(name, marketValue, loanValue)
        {
            this.brand = brand;
            this.model = model;
            this.condition = condition;
        }

        // Второй конструктор
        public PawnShopTechnique(string name, decimal marketValue, decimal loanValue)
            : this(name, marketValue, loanValue, "Unknown", "Unknown", "Good") { }

        public override string GetDescription()
        {
            return $"{name}: {brand} {model}, состояние: {condition}, стоимость {marketValue}";
        }

        public void UpdateCondition(string newCondition)
        {
            condition = newCondition;
            Console.WriteLine($"Состояние {name} обновлено на {condition}.");
        }

        /// <summary>
        /// проверка на возможность займа
        /// </summary>
        public bool IaAbleForLoan(decimal value)
        {
            return marketValue >= value;
        }

        /// <summary>
        /// вывод информации по модели
        /// </summary>=
        public string GetBrand() => brand;

        /// <summary>
        /// изменение модели
        /// </summary>
        public void SetModel(string newModel) => model = newModel;

        /// <summary>
        /// информация о предмете
        /// </summary>
        public void PrintDetailedInfo() => Console.WriteLine($"Техника: {brand} {model}, Состояние: {condition}, Залоговая сумма: {loanValue:C}");
        
    }
}
