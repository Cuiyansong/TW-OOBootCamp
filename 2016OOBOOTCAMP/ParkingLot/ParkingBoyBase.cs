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
            var parkingLot = ParkingLots.OrderByDescending(OrderFunc).FirstOrDefault(_ => !_.IsParkingLotFull);
            return parkingLot == null ? null : parkingLot.Park(car);
        }

        public bool IsParkingLotFull 
        {
            get { return ParkingLots.TrueForAll(_ => _.IsParkingLotFull); }
        }

        public int EmptySpaceCount { get; private set; }

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
