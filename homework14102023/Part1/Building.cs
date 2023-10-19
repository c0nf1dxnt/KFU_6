using System;

namespace Part1
{
    public class Building
    {
        private int buildingNumber;
        private int height;
        private int floors;
        private int apartments;
        private int entrances;
        private static int lastBuildingNumber = 0;

        public Building(int height, int floors, int apartments, int entrances)
        {
            buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        public int GetBuildingNumber()
        {
            return buildingNumber;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetFloors()
        {
            return floors;
        }

        public int GetApartments()
        {
            return apartments;
        }

        public int GetEntrances()
        {
            return entrances;
        }

        private static int GenerateBuildingNumber()
        {
            return ++lastBuildingNumber;
        }

        public double CalculateFloorHeight()
        {
            return (double)height / floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return apartments / floors;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер здания: {buildingNumber}");
            Console.WriteLine($"Высота здания: {height}");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {CalculateFloorHeight()}");
            Console.WriteLine($"Количество квартир в подъезде {CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Количество квартир на этаже: {CalculateApartmentsPerFloor()}");
        }
    }
}
