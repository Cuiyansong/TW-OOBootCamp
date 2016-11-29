using System.Collections.Generic;
using System.Linq;
using OOBootCamp;

namespace ParkingLot.Tests
{
    public class ParkingManager: ParkingBoyBase
    {
        public ParkingManager(params IParking[] parkingLot)
            : base(parkingLot)
        {
        }
    }
}