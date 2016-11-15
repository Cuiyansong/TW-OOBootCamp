using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOBootCamp;

namespace ParkingLot.Tests
{
    [TestClass]
    public class ParkingLotFacts
    {
        [TestMethod]
        public void given_a_parking_lot_when_park_a_car_then_I_can_pick_a_car()
        {
            var p = new OOBootCamp.ParkingLot(1);
            var car = new Car("car");

            var carId = p.Park(car);

            Assert.AreSame(car, p.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_when_parking_two_car_then_I_can_pick_all_of_them()
        {
            var parkingLot = new OOBootCamp.ParkingLot(2);
            var firstCar = new Car("Car One");
            var secondCar = new Car("Second One");

            parkingLot.Park(firstCar);
            var secondCarId = parkingLot.Park(secondCar);

            Assert.AreSame(secondCar, parkingLot.Pick(secondCarId));
        }

        [TestMethod]
        public void given_a_parking_lot_when_parking_a_car_then_I_can_only_pick_one()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var myCar = new Car("my own car is unique");

            var myCarId = parkingLot.Park(myCar);
            parkingLot.Pick(myCarId);

            Assert.IsNull(parkingLot.Pick(myCarId));
        }

        [TestMethod]
        public void given_a_parking_lot_when_not_parking_a_car_then_I_can_not_pick_a_car()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var notParkedCar = new Car("car");

            Assert.IsNull(parkingLot.Pick(notParkedCar.Id));
        }

        [TestMethod]
        public void given_a_parking_lot_with_no_empty_space_when_parking_a_car_then_I_can_not_park()
        {
            var parkingLot = new OOBootCamp.ParkingLot(0);
            var car = new Car("car");

            var carId = parkingLot.Park(car);

            Assert.IsNull(carId);
        }

        [TestMethod]
        public void given_a_parking_lot_with_one_space_when_I_park_the_first_car_and_pick_the_first_car_then_I_can_park_the_second_one ()
        {
            var parkingLot = new OOBootCamp.ParkingLot(1);
            var firstCar = new Car("first car");
            var secondCar = new Car("second car");

            var firstCarId = parkingLot.Park(firstCar);
            parkingLot.Pick(firstCarId);
            var secondCarId = parkingLot.Park(secondCar);

            Assert.AreSame(secondCar, parkingLot.Pick(secondCarId));
        }
    }
}
