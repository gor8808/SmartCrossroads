using System;
using SmartCrossroadsClassLibrary;

namespace SmartCrossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatatorForLights calculatatorForLights = 
                new CalculatatorForLights();
            float generealTime = calculatatorForLights.CalculateGeneralTimeForAllLights();
            Console.WriteLine($"General Time -- {generealTime}");
        }
    }
}
