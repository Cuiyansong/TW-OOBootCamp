using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class SmartParkingBoy: ParkingBoyBase
    {
        public SmartParkingBoy(params IParking[] parkingLot)
            : base(parkingLot)
        {
        }
    }
}