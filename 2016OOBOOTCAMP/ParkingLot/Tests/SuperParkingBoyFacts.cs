using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParkingLot.Tests
{
    [TestClass]
    public class SuperParkingBoyFacts
    {
        [TestMethod]
        public void given_a_parkingLot_and_a_super_parking_boy_when_super_boy_park_a_car_then_the_car_in_the_parkingLot()
        {
            var firstParkinglot = new ParkingLot(1);
            var superParkingBoy = new SuperParkingBoy(firstParkinglot);
            var car = new Car("car");

            var carId = superParkingBoy.Park(car);

            Assert.AreSame(car, firstParkinglot.Pick(carId));
        }

        [TestMethod]
        public void given_a_parkingLot_and_a_super_parking_boy_when_super_park_a_car_then_super_boy_pick_the_car_in_the_parkingLot()
        {
            var firstParkinglot = new ParkingLot(1);
            var superParkingBoy = new SuperParkingBoy(firstParkinglot);
            var car = new Car("car");
            var carId = superParkingBoy.Park(car);

            var pickedCar = superParkingBoy.Pick(carId);
            Assert.AreSame(car, pickedCar);
        }

        [TestMethod]
        public void given_two_parkinglot_and_the_first_parkinglot_emptyRate_is_larger_than_the_second_one_when_super_boy_park_a_car_then_the_first_parkinglot_could_pick_the_car()
        {
            var firstPrakingLot = new ParkingLot(4);
            var secondPrakingLot = new ParkingLot(3);
            var car = new Car("car");
            var parkedCarInFirstParkingLot = new Car("car parked in the first parkinglot");
            var parkedCarInSecondParkingLot = new Car("car parked in the second parkinglot");
            firstPrakingLot.Park(parkedCarInFirstParkingLot);
            secondPrakingLot.Park(parkedCarInSecondParkingLot);
            var superBoy = new SuperParkingBoy(firstPrakingLot, secondPrakingLot);

            var carId = superBoy.Park(car);

            Assert.AreSame(car, firstPrakingLot.Pick(carId));
        }

        [TestMethod]
        public void given_two_parkinglot_and_the_first_parkinglot_emptyRate_is_smaller_than_the_second_one_when_super_boy_park_a_car_then_the_second_parkinglot_could_pick_the_car()
        {
            var firstPrakingLot = new ParkingLot(3);
            var secondPrakingLot = new ParkingLot(4);
            var car = new Car("car");
            var parkedCarInFirstParkingLot = new Car("car parked in the first parkinglot");
            var parkedCarInSecondParkingLot = new Car("car parked in the second parkinglot");
            firstPrakingLot.Park(parkedCarInFirstParkingLot);
            secondPrakingLot.Park(parkedCarInSecondParkingLot);
            var superBoy = new SuperParkingBoy(firstPrakingLot, secondPrakingLot);

            var carId = superBoy.Park(car);

            Assert.AreSame(car, secondPrakingLot.Pick(carId));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "should call null reference exception")]
        public void
            given_parking_boy_and_super_parking_boy_then_super_boy_can_not_manage_parking_boy()
        {
            var parkingLot = new ParkingLot(0);
            var parkingBoy = new ParkingBoy(parkingLot);
            var superBoy = new SuperParkingBoy(parkingBoy as IParking);

            Assert.IsNull(superBoy.Park(new Car("car")));
        }
    }
}