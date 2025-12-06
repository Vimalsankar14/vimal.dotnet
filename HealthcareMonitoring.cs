
using System;

namespace HealthcareMonitoring
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Reading temperature sensor values.");

            VibrationModule.RunVibrationCheck();

            Console.WriteLine("Temperature Module Execution Completed.");
            Console.ReadLine();
        }
    }

    class VibrationModule
    {
        public static void RunVibrationCheck()
        {
            Console.WriteLine("Vibration Module Executing.");

            Console.WriteLine("Vibration Module Task Completed.");
        }
    }
}