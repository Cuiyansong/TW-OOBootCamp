using System.Collections.Generic;
using System.Linq;

namespace OOBootCamp
{
    public class SuperParkingBoy
    {
        private readonly List<ParkingLot> parkingLots;

        public SuperParkingBoy(List<ParkingLot> parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public string Park(Car car)
        {
            var parkingLot = parkingLots.OrderByDescending(p => (float)p.EmptySpaceCount / p.Capacity).First();
            return parkingLot.Park(car);
        }

        public Car Pick(string carId)
        {
            var parkingLotWithParkedCar = parkingLots.FirstOrDefault(p => p.Pick(carId) != null);
            return parkingLotWithParkedCar != null ? parkingLotWithParkedCar.Pick(carId) : null;
        }
    }
}