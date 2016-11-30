using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public virtual string Name
        {
            get { throw new System.NotImplementedException(); }
        }

        public virtual string Prefix
        {
            get { return "\t\t"; }
        }

        public int EmptySpaceCount
        {
            get { return ParkingLots.Sum(x => x.EmptySpaceCount); }
        }

        public int Capacity
        {
            get { return ParkingLots.Sum(x => x.Capacity); }
        }

        public string BuildReport()
        {
            var output = new StringBuilder();
            var totalEmptySpaceCount = this.ParkingLots.Sum(x => x.EmptySpaceCount);
            var totalCapacity = this.ParkingLots.Sum(x => x.Capacity);

            output.Append(string.Format("{0} {1} {2}", Name, totalEmptySpaceCount, totalCapacity - totalEmptySpaceCount));
            foreach (var item in ParkingLots)
            {
                output.Append(System.Environment.NewLine);
                output.Append(this.Prefix + item.BuildReport());
            }

            return output.ToString();
        }
    }
}
