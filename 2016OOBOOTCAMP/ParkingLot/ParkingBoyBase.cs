using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOBootCamp;

namespace ParkingLot
{
    public class ParkingBoyBase
    {
        protected readonly List<OOBootCamp.ParkingLot> parkingLots = new List<OOBootCamp.ParkingLot>();

        public ParkingBoyBase(params OOBootCamp.ParkingLot[] parkingLots)
        {
            this.parkingLots.AddRange(parkingLots);
        }

        public virtual string Park(Car car)
        {
            return car.Id;
        }

        public virtual Car Pick(string carId)
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
