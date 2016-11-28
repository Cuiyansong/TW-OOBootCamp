using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class SmartParkingBoy: ParkingBoyBase
    {
        public SmartParkingBoy(params ParkingLot[] parkingLot): base(parkingLot)
        {
        }

        protected override float OrderFunc(ParkingLot parkingLot)
        {
            return parkingLot.EmptySpaceCount;
        }
    }
}