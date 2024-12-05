using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    class Building
    {
        private static uint lastBuildingId = 0;
        private uint buildingId;
        private double height;
        private uint floors;
        private uint apartments;
        private uint entrances;


        public Building(double height, uint floors, uint apartments, uint entrances)
        {
            this.buildingId = GenerateBuildingId();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        // Метод для генерации уникального номера здания
        private uint GenerateBuildingId()
        {
            lastBuildingId++;
            return lastBuildingId;
        }

        // Методы для получения значений полей
        public uint GetBuildingId()
        {
            return buildingId;
        }
        public double GetHeight()
        {
            return height;
        }
        public uint GetFloors()
        {
            return floors;
        }
        public uint GetApartments()
        {
            return apartments;
        }
        public uint GetEntrances()
        {
            return entrances;
        }

        // Методы для расчётов
        public double GetFloorHeight()
        {
            return height / floors;
        }
        public uint GetApartmentsPerEntrance()
        {
            return apartments / entrances;
    }        
        public uint GetApartmentsPerFloor()
        {
            return apartments / (floors * entrances);
        } 

        public void PrintInfo()
        {
            Console.WriteLine($"Здание ID: {buildingId}");
            Console.WriteLine($"Высота: {height} м");
            Console.WriteLine($"Этажность: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {GetFloorHeight():F2} м");
            Console.WriteLine($"Квартир на подъезд: {GetApartmentsPerEntrance()}");
            Console.WriteLine($"Квартир на этаже: {GetApartmentsPerFloor()}\n");
        }
    }
}
