using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingLot;

namespace ParkingLot.Tests
{
    [TestClass]
    public class SmartParkingBoyFacts
    {
        [TestMethod]
        public void given_two_parkingLot_with_same_space_and_a_smart_parking_boy_when_smart_boy_park_a_car_then_the_car_in_the_first_parkingLot()
        {
            var firstParkinglot = new ParkingLotLot(1);
            var secondParkinglot = new ParkingLotLot(1);

            var smartParkingBoy = new SmartParkingBoy(firstParkinglot, secondParkinglot);
            var car = new Car("car");
            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, firstParkinglot.Pick(carId));
        }

        [TestMethod]
        public void given_first_parkingLot_with_one_space_and_second_parkingLot_with_two_space_and_a_smart_parking_boy_when_smart_boy_park_a_car_then_the_car_in_the_second_parkingLot()
        {
            var firstParkinglot = new ParkingLotLot(2);
            var secondParkinglot = new ParkingLotLot(2);
            var parkedCar = new Car("parked car");
            firstParkinglot.Park(parkedCar);

            var smartParkingBoy = new SmartParkingBoy(firstParkinglot, secondParkinglot);
            var car = new Car("car");
            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, secondParkinglot.Pick(carId));
        }

        [TestMethod]
        public void given_first_parkingLot_with_two_space_and_second_parkingLot_with_one_space_and_a_smart_parking_boy_when_smart_boy_park_a_car_then_the_car_in_the_first_parkingLot()
        {
            var firstParkinglot = new ParkingLotLot(2);
            var secondParkinglot = new ParkingLotLot(2);
            var parkedCar = new Car("parked car");
            secondParkinglot.Park(parkedCar);

            var smartParkingBoy = new SmartParkingBoy(firstParkinglot, secondParkinglot);
            var car = new Car("car");
            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, firstParkinglot.Pick(carId));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "should call null reference exception")]
        public void
            given_parking_boy_and_smart_parking_boy_then_smart_boy_can_not_manage_parking_boy()
        {
            var parkingLot = new ParkingLotLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);
            var smartParkingBoy = new SmartParkingBoy(parkingBoy as IParkingLot);

            smartParkingBoy.Park(new Car("car"));
        }
    }
}