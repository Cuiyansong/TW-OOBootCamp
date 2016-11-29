using System;
using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class SuperParkingBoy: ParkingBoyBase
    {
        public SuperParkingBoy(params IParking[] parkingLot)
            : base(parkingLot)
        {
        }

        protected override float OrderFunc(IParking parkingLot)
        {
            return (float) parkingLot.EmptySpaceCount / parkingLot.Capacity;
        }
    }
}