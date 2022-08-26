using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    
    {
        public Truck()
        {
        }

        string IVehicle.EngineNoise { get; set; } = "who knows";
        int IVehicle.NumberOfDoors { get; set; } = 2;
        int IVehicle.NumberOfSeats { get; set; } = 2;
        bool IVehicle.NeedADriver { get; set; } = true;
        public string Logo { get; set; } = "Superman";
        public string Performance { get; set; } = "never stops";


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} owns the road while driving");
        }
        public void Parked()
        {
            Console.WriteLine($" {GetType().Name} has specialized parking");
        }
        public void Stalled()
        {
            Console.WriteLine($" {GetType().Name} is head ache if stalled");
        }
    }
}

