
namespace solidvehicles.Vehicles
{
    interface IVehicle
    {
        // an int property called Wheels
        int Wheels { get; set; }
        // an int property called Doors
        int Doors { get; set; }
        // an int property called PassengerCapacity
        int PassengerCapacity { get; set; }
        // a bool property called Winged
        bool Winged { get; set; }
        // a string property called TransmissionType
        string TransmissionType { get; set; }
        // a double property called EngineVolume
        double EngineVolume { get; set; }
        // a double property called MaxWaterSpeed
        double MaxWaterSpeed { get; set; }
        // a double property called MaxLandSpeed
        double MaxLandSpeed { get; set; }
        // a double property called MaxAirSpeed
        double MaxAirSpeed { get; set; }
        // a method called Start() that returns void
        void Start();
        // a method called Stop() that returns void
        void Stop();
        // a method called Drive() that returns void
        void Drive();
        // a method called Fly() that returns void
        void Fly();
    }
}
