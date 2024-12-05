using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myTheme
{
    /// <summary>
    /// ювелирный товар
    /// </summary>
    class PawnShopJewelry : PawnShopItem
    {
        public string material { get; private set; } 
        private double weight { get; set; } 
        public int purity { get; set; } 

        /// <summary>
        /// конструктор
        /// </summary>
        public PawnShopJewelry(string name, decimal marketValue, decimal loanValue, string material, double weight, int purity)
            : base(name, marketValue, loanValue)
        {
            this.material = material;
            this.weight = weight;
            this.purity = purity;
        }

        /// <summary>
        ///конструктор, если не указали часть даннх
        /// </summary>
        public PawnShopJewelry(string name, decimal marketValue, decimal loanValue)
            : this(name, marketValue, loanValue, "не указан", 0, 0) { }

        /// <summary>
        /// получить описание
        /// </summary>
        public override string GetDescription()
        {
            return $"{name}: {material}, вес {weight} г, проба {purity}, стоимость {marketValue}";
        }

        /// <summary>
        /// посчитать стоимость
        /// </summary>
        public decimal CalculateGoldValue(decimal pricePerGram)
        {
            return (decimal) weight * pricePerGram * purity / 100;
        }


        /// <summary>
        /// обновление материала
        /// </summary>
        public void UpdateMaterial(string newMaterial)
        {
            material = newMaterial;
            Console.WriteLine($"Материал для {name} обновлен на {material}.");
        }
    }

}
