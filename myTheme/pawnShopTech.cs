using System;
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
        #region
        public string brand { get; set; }
        private string model { get; set; } 
        public string condition { get; set; }
        #endregion

        /// <summary>
        ///конструктор
        /// </summary>
        public PawnShopTechnique(string name, decimal marketValue, decimal loanValue, string brand, string model, string condition)
            : base(name, marketValue, loanValue)
        {
            this.brand = brand;
            this.model = model;
            this.condition = condition;
        }

        /// <summary>
        ///конструктор, если не указали часть даннх
        /// </summary>
        public PawnShopTechnique(string name, decimal marketValue, decimal loanValue)
            : this(name, marketValue, loanValue, "неизветсно", "неизвестно", "неизвестно") { }

        /// <summary>
        /// получтиь описание
        /// </summary>
        public override string GetDescription()
        {
            return $"{name}: {brand} {model}, состояние: {condition}, стоимость {marketValue}";
        }

        /// <summary>
        /// обновить информацию по состоянию
        /// </summary>
        public void UpdateCondition(string newCondition)
        {
            condition = newCondition;
            Console.WriteLine($"Состояние {name} обновлено на {condition}.");
        }

        /// <summary>
        /// проверка на возможность займа
        /// </summary>
        public bool IsAbleForLoan(decimal value)
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

