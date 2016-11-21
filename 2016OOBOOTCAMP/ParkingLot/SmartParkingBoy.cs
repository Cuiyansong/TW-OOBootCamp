using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class SmartParkingBoy: ParkingBoyBase
    {
        public SmartParkingBoy(params ParkingLot[] parkingLots): base(parkingLots)
        {
        }

        public override string Park(Car car)
        {
            return parkingLots.OrderByDescending(p => p.EmptySpaceCount).First().Park(car);
        }
    }
}