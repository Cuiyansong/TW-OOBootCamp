using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLot
{
    class ParkLot
    {
        private Car car;

        public ParkLot(int capacity)
        {
            
        }


        public Car Pick(string id)
        {
            return car;
        }

        public string Park(Car parkedCar)
        {
            this.car = parkedCar;
            return "1";
        }
    }
}
