using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    public class ParkingBoyBase<T> : IParkable where T : IParkable
    {
        protected readonly List<T> parkingLots = new List<T>();

        public ParkingBoyBase(params T[] parkingLot)
        {
            this.parkingLots.AddRange(parkingLot);
        }

        protected virtual float OrderFunc(T parkingLot)
        {
            return (float)parkingLot.EmptySpaceCount;
        }

        public virtual string Park(Car car)
        {
            var parkingLot = parkingLots.OrderByDescending(OrderFunc).FirstOrDefault(_ => !_.IsParkingLotFull);
            return parkingLot == null ? null : parkingLot.Park(car);
        }

        public bool IsParkingLotFull 
        {
            get { return parkingLots.TrueForAll(_ => _.IsParkingLotFull); }
        }

        public int EmptySpaceCount { get; private set; }

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
