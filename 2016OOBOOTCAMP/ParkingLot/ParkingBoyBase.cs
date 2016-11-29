using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    public class ParkingBoyBase<T> : IParkable where T : IParkable
    {
        protected readonly List<T> ParkingLots = new List<T>();

        public ParkingBoyBase(params T[] parkingLotLot)
        {
            this.ParkingLots.AddRange(parkingLotLot);
        }

        protected virtual float OrderFunc(T parkingLot)
        {
            return (float)parkingLot.EmptySpaceCount;
        }

        public virtual string Park(Car car)
        {
            var parkingLot = ParkingLots.OrderByDescending(OrderFunc).FirstOrDefault(_ => _.EmptySpaceCount != 0);
            return parkingLot == null ? null : parkingLot.Park(car);
        }

        public int EmptySpaceCount 
        {
            get { return ParkingLots.Sum(x => x.EmptySpaceCount); }
        }

        public virtual Car Pick(string carId)
        {
            Car pickedCar = null;
            this.ParkingLots.FirstOrDefault(
                _ =>
                {
                    pickedCar = _.Pick(carId);
                    return pickedCar != null;
                });

            return pickedCar;
        }
    }
}
