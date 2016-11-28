using System.Collections.Generic;
using System.Linq;
using OOBootCamp;

namespace ParkingLot.Tests
{
    public class ParkingManager
    {
        private List<IParking> parkingProxies = new List<IParking>();

        public ParkingManager(params IParking[] parking)
        {
            parkingProxies.AddRange(parking);
        }

        public string Park(Car car)
        {
            var parkingLot = parkingProxies.OrderByDescending(x => !x.IsParkingLotFull).FirstOrDefault();
            return parkingLot == null ? null : parkingLot.Park(car);
        }

        public Car Pick(string carId)
        {
            Car pickedCar = null;
            parkingProxies.FirstOrDefault(
                _ =>
                {
                    pickedCar = _.Pick(carId);
                    return pickedCar != null;
                });

            return pickedCar;
        }
    }
}