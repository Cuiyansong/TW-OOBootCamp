﻿using System;
using System.Collections.Generic;
using System.Linq;
using ParkingLot;

namespace OOBootCamp
{
    public class SuperParkingBoy: ParkingBoyBase
    {
        public SuperParkingBoy(params ParkingLot[] parkingLot): base(parkingLot)
        {
        }

        protected override float OrderFunc(ParkingLot parkingLot)
        {
            return (float) parkingLot.EmptySpaceCount / parkingLot.Capacity;
        }
    }
}