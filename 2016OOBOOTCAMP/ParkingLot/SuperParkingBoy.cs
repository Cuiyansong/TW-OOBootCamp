using System.Collections.Generic;

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
            return this.parkingLots[0].Park(car);
        }

        public Car Pick(string carId)
        {
            return this.parkingLots[0].Pick(carId);
        }
    }
}