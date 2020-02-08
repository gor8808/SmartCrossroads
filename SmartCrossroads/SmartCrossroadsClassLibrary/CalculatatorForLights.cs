using System;

namespace SmartCrossroadsClassLibrary
{
    public class CalculatatorForLights
    {
        public static float CarVelocity { get; private set; } = 1f;
        public float Time { get; private set; }
        public float Distance { get; private set; }
        public float GeneralTime;
        public float CalculateDictance(int whichRoad)
        {
            Cars car = new Cars(5);
            int carsCount = 0;
            switch (whichRoad)
            {
                case 1: // Right
                    carsCount = Crossroads.RightRoadCarsCount;
                    break;
                case 2: // Forward
                    carsCount = Crossroads.ForwardRoadCarsCount;
                    break;
            }
            Distance = carsCount + Cars.MaxCarsCount + 1f;
            return Distance;
        }
        public float CalculateTime(float distance)
        {
            Time = distance / CarVelocity;
            return Time;
        }
        public float CalculateGeneralTimeForAllLights()
        {
            int roadSize = 15;
            //Crossroads.PrintRoads();
            Crossroads Roads = new Crossroads(roadSize);
            
            Roads.PlaceCars(); // Gen Random Cars 
            float distanceForRightRoad = CalculateDictance(1);
            float timeForRightRoad = CalculateTime(distanceForRightRoad);
            float distanceForForwardRoad = CalculateDictance(2);
            float timeForForwardRoud = CalculateTime(distanceForForwardRoad);
            GeneralTime = timeForForwardRoud + timeForRightRoad;
            Console.WriteLine($"Forward Road Cars Count -- {Crossroads.ForwardRoadCarsCount}");
            Console.WriteLine($"Right Road Cars Count   -- {Crossroads.RightRoadCarsCount}");
            return GeneralTime;

        }
    }
}
