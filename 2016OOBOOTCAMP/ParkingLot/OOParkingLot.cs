using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLot
{
    public class OOParkingLot : IParkingLot, IReport
    {
        private readonly Dictionary<string, Car> parkedCars;
        private readonly int capacity = 0;

        public int EmptySpaceCount
        {
            get { return capacity - this.parkedCars.Count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public OOParkingLot(int capacity)
        {
            this.capacity = capacity;
            parkedCars = new Dictionary<string, Car>(capacity);
        }

        public Car Pick(string id)
        {
            if (!parkedCars.ContainsKey(id))
            {
                return null;
            }

            var pickedCar = parkedCars[id];
            parkedCars.Remove(pickedCar.Id);
            return pickedCar;
        }

        public string Park(Car parkedCar)
        {
            if (this.Capacity == this.parkedCars.Count)
            {
                return null;
            }

            parkedCars.Add(parkedCar.Id, parkedCar);
            return parkedCar.Id;
        }

        public string GetReport()
        {
            var output = new StringBuilder();
            var totalEmptySpaceCount = this.EmptySpaceCount;
            var totalCapacity = this.capacity;

            output.Append(string.Format("{0} {1} {2}", GetName(), totalEmptySpaceCount, totalCapacity - totalEmptySpaceCount));
            return output.ToString();
        }

        public string GetName()
        {
            return "P";
        }
    }
}
