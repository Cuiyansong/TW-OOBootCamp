using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParkingLot
{
    [TestClass]
    public class ParkingLotTests
    {
        [TestMethod]
        public void Given_a_parking_lot_when_park_a_car_then_I_can_pick_a_car()
        {
            var p = new ParkLot(1);
            var car = new Car();

            var carId = p.Park(car);

            Assert.AreSame(car, p.Pick(carId));
        }
    }
}
