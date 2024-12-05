using myTheme;
using System;

namespace myTheme
{
    class Program
    {
        static void Main(string[] args)
        {
            //ювелирка
            PawnShopJewelry ring = new PawnShopJewelry("Кольцо", 50000m, 30000m, "Золото", 10, 585);
            PawnShopJewelry bracelet = new PawnShopJewelry("Браслет", 70000m, 45000m);
            
            //техника
            PawnShopTechnique phone = new PawnShopTechnique("Смартфон", 60000m, 40000m, "Apple", "iPhone 14", "Новый");
            PawnShopTechnique laptop = new PawnShopTechnique("Ноутбук", 80000m, 50000m);

            //антиквариат
            PawnShopAntique vase = new PawnShopAntique("Антикварная ваза", 120000m, 80000m, "5-6 век", "Ценный артефакт", "Византия");

            ring.PrintInfo();
            Console.WriteLine(ring.GetDescription());
            ring.Redeem();

            phone.PrintInfo();
            phone.UpdateCondition("Идеальное");

            vase.PrintAntiqueDetails();
            vase.VerifyAuthenticity();
            vase.UpdateHistoricalValue("Культурное наследие");
            vase.UpdateOrigin("Шанхай");

            // Итоговый вывод
            Console.WriteLine("\nИтоговая информация:");
            ring.PrintInfo();
            bracelet.PrintInfo();
            phone.PrintInfo();
            laptop.PrintInfo();
            vase.PrintInfo();
        }
    }
}