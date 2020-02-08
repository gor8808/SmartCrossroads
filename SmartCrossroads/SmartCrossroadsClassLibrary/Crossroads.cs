using System;

namespace SmartCrossroadsClassLibrary
{
    public class Crossroads
    {
        public static int RoadsSize { get; private set; } = 15;
        public static int[,] Roads = new int[RoadsSize, RoadsSize];
        public static int RightRoadCarsCount;
        public static int ForwardRoadCarsCount;

        public Crossroads(int roadSize)
        {
            RoadsSize = roadSize;
        }
        public static void PrintRoads()
        {
            for (int i = 0; i < RoadsSize; i++)
            {
                for (int j = 0; j < RoadsSize; j++)
                {
                    Console.Write(Roads[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        public void PlaceCars()
        {
            CarsGenerator roadCarsGen = new CarsGenerator();
            RightRoadCarsCount = roadCarsGen.RandomCarsCount(Cars.MaxCarsCount);
            ForwardRoadCarsCount = roadCarsGen.RandomCarsCount(Cars.MaxCarsCount);
            // TODO: Place in matrix
        }
    }
}
