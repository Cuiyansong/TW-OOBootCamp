using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class ParkingBoy: ParkingBoyBase
    {
        public ParkingBoy(params ParkingLot[] parkingLot): base(parkingLot)
        {
            
        }
    }
}