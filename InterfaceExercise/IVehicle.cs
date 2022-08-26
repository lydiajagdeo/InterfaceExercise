using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string EngineNoise { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public bool NeedADriver { get; set; }



        public void Drive();
        public void Parked();
        public void Stalled();
        

    }


}

