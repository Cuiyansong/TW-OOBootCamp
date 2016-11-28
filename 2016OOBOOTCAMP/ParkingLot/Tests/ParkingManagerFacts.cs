using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBootCamp;

namespace ParkingLot.Tests
{
    [TestClass]
    public class ParkingManagerFacts
    {
        [TestMethod]
        public void given_a_parkingLot_and_a_parking_manager_when_parking_manager_park_a_car_then_he_can_pick_the_car()
        {
            var parkinglot = new OOBootCamp.ParkingLot(1);
            var manager = new ParkingManager(parkinglot);
            var car = new Car("car");

            var carId = manager.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_and_a_parking_boy_which_managed_by_parking_manager_when_parking_boy_park_a_car_then_manager_could_pick_the_car()
        {
            var parkinglot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkinglot);
            var manager = new ParkingManager(parkingBoy);
            var car = new Car("car");

            var carId = parkingBoy.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_and_a_smart_parking_boy_which_managed_by_parking_manager_when_parking_boy_park_a_car_then_manager_could_pick_the_car()
        {
            var parkinglot = new OOBootCamp.ParkingLot(1);
            var smartParkingBoy = new SmartParkingBoy(parkinglot);
            var manager = new ParkingManager(smartParkingBoy);
            var car = new Car("car");

            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, manager.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_and_a_super_parking_boy_which_managed_by_parking_manager_when_parking_boy_park_a_car_then_manager_could_pick_the_car()
        {
            var parkinglot = new OOBootCamp.ParkingLot(1);
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
            var emptyParkinglot = new OOBootCamp.ParkingLot(0);
            var parkinglot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkinglot);
            var manager = new ParkingManager(emptyParkinglot, parkingBoy);
            var car = new Car("car");

            var carId = manager.Park(car);

            Assert.AreSame(car, parkingBoy.Pick(carId));
        }
    }

    public class ParkingManager
    {
        private List<IParking> parkingProxies = new List<IParking>();

        public ParkingManager(params IParking[] parking)
        {
            parkingProxies.AddRange(parking);
        }

        public string Park(Car car)
        {
            var parkingLot = parkingProxies.OrderByDescending(x => !x.IsParkingLotFull).FirstOrDefault();
            return parkingLot == null ? null : parkingLot.Park(car);
        }

        public Car Pick(string carId)
        {
            Car pickedCar = null;
            parkingProxies.FirstOrDefault(
                _ =>
                {
                    pickedCar = _.Pick(carId);
                    return pickedCar != null;
                });

            return pickedCar;
        }
    }
}