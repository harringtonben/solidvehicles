using solidvehicles.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidvehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var jumbojet = new AirVehicle
            {
                Name = "747",
                Wheels = 3,
                Doors = 4,
                PassengerCapacity = 200,
                Winged = true,
                MaxAirSpeed = 300
            };

            var airforceone = new AirVehicle
            {
                Name = "Air Force One",
                Wheels = 3,
                Doors = 4,
                PassengerCapacity = 20,
                Winged = true,
                MaxAirSpeed = 400
            };

            var ferrari = new LandVehicle
            {
                Name = "Ferrari",
                Wheels = 4,
                Doors = 2,
                PassengerCapacity = 2,
                TransmissionType = "Manual",
                MaxLandSpeed = 120
            };

            var minivan = new LandVehicle
            {
                Name = "Mini Van",
                Wheels = 4,
                Doors = 4,
                PassengerCapacity = 7,
                TransmissionType = "Auotmatic",
                MaxLandSpeed = 50
            };

            var jetski = new WaterVehicle
            {
                Name = "Jetski",
                PassengerCapacity = 2,
                MaxWaterSpeed = 60.2
            };

            var speedboat = new WaterVehicle
            {
                Name = "Speedboat",
                PassengerCapacity = 6,
                MaxWaterSpeed = 86.3
            };
            // Build a collection of all vehicles that fly

            // With a single `foreach`, have each vehicle Fly()



            // Build a collection of all vehicles that operate on roads

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
