using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidvehicles.Vehicles
{
    class LandVehicle : IVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {Name} screams down the highway at a crazy top speed of {MaxLandSpeed} mph.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
