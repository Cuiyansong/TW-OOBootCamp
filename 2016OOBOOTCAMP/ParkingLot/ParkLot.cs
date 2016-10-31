using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLot
{
    class ParkLot
    {
        private readonly Dictionary<string, Car> cars;
        private int capacity = 0;

        public ParkLot(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>(capacity);
        }

        public Car Pick(string id)
        {
            if (!cars.ContainsKey(id))
            {
                return null;
            }

            var pickedCar = cars[id];
            cars.Remove(pickedCar.Id);
            return pickedCar;
        }

        public string Park(Car parkedCar)
        {
            if (cars.Count + 1 > capacity)
            {
                return null;
            }

            cars.Add(parkedCar.Id, parkedCar);
            return parkedCar.Id;
        }
    }
}
