using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myTheme
{
    /// <summary>
    /// антикварный товар
    /// </summary>
    class PawnShopAntique : PawnShopItem
    {
        public string era { get; set; } 
        public string historicalValue { get; set; } 
        public string origin { get; private set; } 

        /// <summary>
        /// конструктор антиквара
        /// </summary>
        public PawnShopAntique(string name, decimal marketValue, decimal loanValue, string era, string historicalValue, string origin)
            : base(name, marketValue, loanValue)
        {
            this.era = era;
            this.historicalValue = historicalValue;
            this.origin = origin;
        }

        // Второй конструктор
        public PawnShopAntique(int id, string name, decimal marketValue, decimal loanValue)
            : this(name, marketValue, loanValue, "Unknown", "No Data", "Unknown") { }

        public override string GetDescription()
        {
            return $"{name}: эпоха {era}, значимость: {historicalValue}, происхождение: {origin}, стоимость {marketValue:C}";
        }

        public bool VerifyAuthenticity()
        {
            // Простая проверка (пример)
            Console.WriteLine($"{name}: проверка подлинности завершена.");
            return true;
        }

        public void UpdateHistoricalValue(string newValue)
        {
            historicalValue = newValue;
            Console.WriteLine($"Историческая значимость {name} обновлена: {historicalValue}.");
        }

        public void UpdateOrigin(string newOrigin)
        {
            origin = newOrigin;
            Console.WriteLine($"Происхождение {name} обновлено: {origin}.");
        }

        public void PrintAntiqueDetails()
        {
            Console.WriteLine($"Антиквариат: {name}, Эпоха: {era}, Значимость: {historicalValue}, Происхождение: {origin}, Сумма займа: {loanValue}");
        }
    }

}
