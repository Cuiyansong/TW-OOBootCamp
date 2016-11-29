using System.Collections.Generic;

namespace ParkingLot
{
    public class OOParkingLot : IParkingLot
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
        
        public bool IsParkingLotFull
        {
            get { return parkedCars.Count == capacity; }
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
            if (IsParkingLotFull)
            {
                return null;
            }

            parkedCars.Add(parkedCar.Id, parkedCar);
            return parkedCar.Id;
        }
    }
}
