using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }


        string IVehicle.EngineNoise { get; set; } = "vroom";
        int IVehicle.NumberOfDoors { get; set; } = 4;
        int IVehicle.NumberOfSeats { get; set; } = 5;
        bool IVehicle.NeedADriver { get; set; } = true;
        public string Logo { get; set; } = "Ram";
        public string Performance { get; set; } = "Always on the go";


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now drives forward");
        }
        public void Parked()
        {
            Console.WriteLine($" {GetType().Name} is now parked");
        }
        public void Stalled()
        {
            Console.WriteLine($" {GetType().Name} is now stalled");
        }

    }
}

