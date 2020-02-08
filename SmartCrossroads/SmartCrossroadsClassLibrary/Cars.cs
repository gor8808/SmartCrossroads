namespace SmartCrossroadsClassLibrary
{
    public class Cars
    {
        public static int MaxCarsCount { get; private set; } = 5;
        private (int, int) Coordinates;
        public Cars(int maxCarsCount)
        {
            MaxCarsCount = maxCarsCount;
        }
        public Cars(int coordinateX, int coordinateY)
        {
            Coordinates = (coordinateX,coordinateY);
        }
    }
}
