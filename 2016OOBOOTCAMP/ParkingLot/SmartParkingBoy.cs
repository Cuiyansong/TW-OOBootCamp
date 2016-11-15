using System.Collections.Generic;
using System.Linq;

namespace OOBootCamp
{
    public class SmartParkingBoy
    {
        private readonly List<ParkingLot> parkingLots;

        public SmartParkingBoy(List<ParkingLot> parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public Car Pick(string carId)
        {
            var parkingLotWithParkedCar = parkingLots.FirstOrDefault(p => p.Contains(carId));
            return parkingLotWithParkedCar != null ? parkingLotWithParkedCar.Pick(carId) : null;
        }

        public string Park(Car car)
        {
            return parkingLots.OrderByDescending(p => p.EmptySpaceCount).First().Park(car);
        }
    }
}