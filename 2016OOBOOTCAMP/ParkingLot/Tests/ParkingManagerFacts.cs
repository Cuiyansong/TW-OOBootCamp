using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingLot;

namespace ParkingLot.Tests
{
    [TestClass]
    public class ParkingManagerFacts
    {
        [TestMethod]
        public void given_a_parkingLot_and_a_parking_manager_when_parking_manager_park_a_car_then_he_can_pick_the_car()
        {
            var parkinglot = new ParkingLotLot(1);
            var manager = new ParkingManager(parkinglot);
            var car = new Car("car");

            var carId = manager.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_and_a_parking_boy_which_managed_by_parking_manager_when_parking_boy_park_a_car_then_manager_could_pick_the_car()
        {
            var parkinglot = new ParkingLotLot(1);
            var parkingBoy = new ParkingBoy(parkinglot);
            var manager = new ParkingManager(parkingBoy);
            var car = new Car("car");

            var carId = parkingBoy.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_and_a_smart_parking_boy_which_managed_by_parking_manager_when_parking_boy_park_a_car_then_manager_could_pick_the_car()
        {
            var parkinglot = new ParkingLotLot(1);
            var smartParkingBoy = new SmartParkingBoy(parkinglot);
            var manager = new ParkingManager(smartParkingBoy);
            var car = new Car("car");

            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_and_a_super_parking_boy_which_managed_by_parking_manager_when_parking_boy_park_a_car_then_manager_could_pick_the_car()
        {
            var parkinglot = new ParkingLotLot(1);
            var superParkingBoy = new SuperParkingBoy(parkinglot);
            var manager = new ParkingManager(superParkingBoy);
            var car = new Car("car");

            var carId = superParkingBoy.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void
            given_a_full_parking_lot_and_a_parking_boy_which_managed_by_parking_mananger_with_one_space_parking_lot_when_parking_manager_park_the_car_then_parking_boy_could_pick_the_car
            ()
        {
            var emptyParkinglot = new ParkingLotLot(0);
            var parkinglot = new ParkingLotLot(1);
            var parkingBoy = new ParkingBoy(parkinglot);
            var manager = new ParkingManager(emptyParkinglot, parkingBoy);
            var car = new Car("car");

            var carId = manager.Park(car);

            Assert.AreSame(car, parkingBoy.Pick(carId));
        }

        [TestMethod]
        public void
            given_a_smart_boy_with_empty_parking_lot_and_a_super_boy_with_one_space_parking_lot_both_managed_by_parking_manager_when_parking_manager_park_the_car_then_super_boy_could_pick_the_car
            ()
        {
            var emptyParkinglot = new ParkingLotLot(0);
            var parkinglot = new ParkingLotLot(1);
            var smartBoy = new SmartParkingBoy(emptyParkinglot);
            var superBoy = new SuperParkingBoy(parkinglot);
            var manager = new ParkingManager(smartBoy, superBoy);
            var car = new Car("car");

            var carId = manager.Park(car);

            Assert.AreSame(car, superBoy.Pick(carId));
        }

        [TestMethod]
        public void
            given_a_smart_boy_with_empty_parking_lot_and_one_space_parking_lot_and_a_super_boy_with_one_space_parking_lot_both_managed_by_parking_manager_when_parking_manager_park_the_car_then_super_boy_could_pick_the_car
            ()
        {
            var emptyParkinglot = new ParkingLotLot(0);
            var firstNotEmptyParkingLot = new ParkingLotLot(1);
            var secondNotEmptyParkingLot = new ParkingLotLot(1);
            var smartBoy = new SmartParkingBoy(emptyParkinglot, firstNotEmptyParkingLot);
            var superBoy = new SuperParkingBoy(secondNotEmptyParkingLot);
            var manager = new ParkingManager(smartBoy, superBoy);
            var car = new Car("car");

            var carId = manager.Park(car);

            Assert.AreSame(car, smartBoy.Pick(carId));
        }
    }
}