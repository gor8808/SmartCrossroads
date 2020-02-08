using System;

namespace SmartCrossroadsClassLibrary
{
    class CarsGenerator
    {
        public int RandomCarsCount(int max)
        {
            Random random = new Random();
            return random.Next(1, max);
        }
        public int RandomCarsCount(int max, int min)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
