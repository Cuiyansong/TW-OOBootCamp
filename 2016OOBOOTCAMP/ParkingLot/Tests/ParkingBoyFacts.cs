using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBootCamp;

namespace ParkingLot.Tests
{
    [TestClass]
    public class ParkingBoyFacts
    {
        [TestMethod]
        public void
            given_a_parking_lot_and_a_parking_boy_when_parking_boy_park_a_car_then_parking_boy_can_pick_the_car
            ()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);

            var myCar = new Car("a");
            var carId = parkingBoy.Park(myCar);

            Assert.AreSame(myCar, parkingBoy.Pick(carId));
        }

        [TestMethod]
        public void
            given_a_parking_lot_and_parking_boy_when_parking_boy_park_a_car_then_pick_the_car_from_parking_lot
            ()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);

            var myCar = new Car("a");
            var carId = parkingBoy.Park(myCar);

            Assert.AreSame(myCar, parkingLot.Pick(carId));
        }

        [TestMethod]
        public void
           given_a_parking_lot_and_a_parking_boy_when_park_a_car_in_parking_lot_directly_then_parking_boy_can_pick_the_car
            ()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);

            var myCar = new Car("a");
            var carId = parkingLot.Park(myCar);

            Assert.AreSame(myCar, parkingBoy.Pick(carId));
        }

        [TestMethod]
        public void
            given_a_no_space_parking_lot_and_a_parking_boy_when_parking_boy_park_a_car_then_can_not_park_a_car
            ()
        {
            var parkingLot = new OOBootCamp.ParkingLot(0);
            var parkingBoy = new ParkingBoy(parkingLot);

            var myCar = new Car("a");
            var carId = parkingBoy.Park(myCar);

            Assert.AreSame(null, carId);
        }

        [TestMethod]
        public void
   given_a_parking_lot_and_a_parking_boy_then_parking_boy_park_a_car_and_pick_the_car_then_parking_boy_cannot_pick_the_car
            ()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(parkingLot);
            var myCar = new Car("a");

            var carId = parkingBoy.Park(myCar);
            parkingBoy.Pick(carId);
            
            Assert.AreEqual(null, parkingBoy.Pick(carId));
        }

        [TestMethod]
        public void
            given_two_parking_lot_with_space_and_a_parking_boy_when_parking_boy_park_a_car_then_the_car_parked_in_the_first_parking_lot
            ()
        {
            var firstParkingLot = new OOBootCamp.ParkingLot(1);
            var secondParkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(new List<OOBootCamp.ParkingLot>() {firstParkingLot, secondParkingLot });
            var car = new Car("car");

            var carId = parkingBoy.Park(car);

            Assert.AreSame(car, firstParkingLot.Pick(carId));
        }

        [TestMethod]
        public void
            given_two_parking_lot_with_first_parking_lot_is_full_when_parking_boy_park_a_car_then_the_car_parked_in_the_second_parking_lot
            ()
        {
            var firstParkingLot = new OOBootCamp.ParkingLot(0);
            var secondParkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(new List<OOBootCamp.ParkingLot>() { firstParkingLot, secondParkingLot });
            var car = new Car("car");

            var carId = parkingBoy.Park(car);

            Assert.AreSame(car, secondParkingLot.Pick(carId));
        }

        [TestMethod]
        public void
            given_two_parking_lot_with_all_parking_lot_is_full_when_parking_boy_park_a_car_then_the_car_cannot_be_parked
            ()
        {
            var firstParkingLot = new OOBootCamp.ParkingLot(0);
            var secondParkingLot = new OOBootCamp.ParkingLot(0);
            var parkingBoy = new ParkingBoy(new List<OOBootCamp.ParkingLot>() { firstParkingLot, secondParkingLot });
            var car = new Car("car");

            var carId = parkingBoy.Park(car);

            Assert.AreSame(null, carId);
        }

        [TestMethod]
        public void
            given_two_parking_lot_when_parking_boy_park_a_car_and_pick_the_car_then_parking_boy_cannot_pick_a_car
            ()
        {
            var firstParkingLot = new OOBootCamp.ParkingLot(1);
            var secondParkingLot = new OOBootCamp.ParkingLot(1);
            var parkingBoy = new ParkingBoy(new List<OOBootCamp.ParkingLot>() { firstParkingLot, secondParkingLot });
            var car = new Car("car");

            var carId = parkingBoy.Park(car);
            parkingBoy.Pick(carId);

            Assert.AreSame(null, parkingBoy.Pick(carId));
        }
    }
}