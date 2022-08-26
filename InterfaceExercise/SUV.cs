using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    
    {
        public SUV()
        {
        }
        string IVehicle.EngineNoise { get; set; } = "monster";
        int IVehicle.NumberOfDoors { get; set; } = 4;
        int IVehicle.NumberOfSeats { get; set; } = 5;
        bool IVehicle.NeedADriver { get; set; } = true;
        public string Logo { get; set; } = "Warlock";
        public string Performance { get; set; } = "Wizardry";


        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} uses a lot of gas");
        }
        public void Parked()
        {
            Console.WriteLine($" {GetType().Name} needs a lot of space to be parked");
        }
        public void Stalled()
        {
            Console.WriteLine($" {GetType().Name} costs a lot to be towed if stalled");
        }
    }
}

