using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class SuperParkingBoy: ParkingBoyBase
    {
        public SuperParkingBoy(params ParkingLot[] parkingLots): base(parkingLots)
        {
        }

        public override string Park(Car car)
        {
            var parkingLot = parkingLots.OrderByDescending(p => (float)p.EmptySpaceCount / p.Capacity).First();
            return parkingLot.Park(car);
        }
    }
}