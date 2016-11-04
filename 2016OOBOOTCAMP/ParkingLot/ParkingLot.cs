using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOBootCamp;

namespace OOBootCamp
{
    public class ParkingLot
    {
        private readonly Dictionary<string, Car> parkedCars;
        private readonly int capacity = 0;

        public int EmptySpaceCount
        {
            get { return capacity - this.parkedCars.Count; }
        }

        public ParkingLot(int capacity)
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
            if (IsParkingLotFull())
            {
                return null;
            }

            parkedCars.Add(parkedCar.Id, parkedCar);
            return parkedCar.Id;
        }

        public bool IsParkingLotFull()
        {
            return parkedCars.Count == capacity;
        }
    }
}
