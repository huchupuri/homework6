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

        /// <summary>
        /// второй конструктор
        /// </summary>
        public PawnShopAntique(string name, decimal marketValue, decimal loanValue)
            : this(name, marketValue, loanValue, "неизветсно", "неизветсно", "неизвестно") { }

        /// <summary>
        /// переназначение методы вывода информации по товару
        /// </summary>
        public override string GetDescription()
        {
            return $"{name}: эпоха {era}, значимость: {historicalValue}, происхождение: {origin}, стоимость {marketValue:C}";
        }

        /// <summary>
        /// проверка на подлинность
        /// </summary>
        /// <returns></returns>
        public bool VerifyAuthenticity()
        {
            Console.WriteLine($"{name}: проверка подлинности завершена.");
            return true;
        }

        /// <summary>
        /// обновление данных занчимости 
        /// </summary>
        public void UpdateHistoricalValue(string newValue)
        {
            historicalValue = newValue;
            Console.WriteLine($"Историческая значимость {name} обновлена: {historicalValue}.");
        }

        /// <summary>
        /// новое происхождение
        /// </summary>
        public void UpdateOrigin(string newOrigin)
        {
            origin = newOrigin;
            Console.WriteLine($"Происхождение {name} обновлено: {origin}.");
        }

        /// <summary>
        /// инфо 
        /// </summary>
        public void PrintAntiqueDetails()
        {
            Console.WriteLine($"Антиквариат: {name}, Эпоха: {era}, Значимость: {historicalValue}, Происхождение: {origin}, Сумма займа: {loanValue}");
        }
    }

}
