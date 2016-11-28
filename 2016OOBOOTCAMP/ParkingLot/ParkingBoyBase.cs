using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOBootCamp;

namespace ParkingLot
{
    public class ParkingBoyBase : IParking
    {
        protected readonly List<OOBootCamp.ParkingLot> parkingLots = new List<OOBootCamp.ParkingLot>();

        public ParkingBoyBase(params OOBootCamp.ParkingLot[] parkingLot)
        {
            this.parkingLots.AddRange(parkingLot);
        }

        protected virtual float OrderFunc(OOBootCamp.ParkingLot parkingLot)
        {
            return (float)parkingLot.EmptySpaceCount;
        }

        public virtual string Park(Car car)
        {
            var parkingLot = parkingLots.OrderByDescending(OrderFunc).FirstOrDefault(_ => !_.IsParkingLotFull);
            return parkingLot == null ? null : parkingLot.Park(car);
        }

        public bool IsParkingLotFull { get; private set; }

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
