using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class ParkingBoy: ParkingBoyBase
    {
        public ParkingBoy(params ParkingLot[] parkingLots): base(parkingLots)
        {
            
        }

        public override string Park(Car car)
        {
            var emptyParkingLot = this.parkingLots.FirstOrDefault(_ => !_.IsParkingLotFull());
            return emptyParkingLot == null ? null : emptyParkingLot.Park(car);
        }
    }
}