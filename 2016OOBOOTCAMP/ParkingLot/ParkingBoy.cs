using System.Collections.Generic;
using System.Linq;

namespace OOBootCamp
{
    public class ParkingBoy
    {
        private readonly List<ParkingLot> parkingLots = new List<ParkingLot>();

        public ParkingBoy(ParkingLot parkingLot)
        {
            this.parkingLots.Add(parkingLot);
        }

        public ParkingBoy(List<ParkingLot> parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public string Park(Car car)
        {
            var emptyParkingLot = this.parkingLots.FirstOrDefault(_ => !_.IsParkingLotFull());
            return emptyParkingLot == null ? null : emptyParkingLot.Park(car);
        }

        public Car Pick(string carId)
        {
            Car pickedCar = null;
            this.parkingLots.FirstOrDefault(
                _ =>
                {
                    pickedCar = _.Pick(carId);
                    return pickedCar != null;
                });

            return pickedCar;
        }
    }
}