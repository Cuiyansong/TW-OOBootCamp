using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOBootCamp
{
    [TestClass]
    public class ParkingLotTests
    {
        [TestMethod]
        public void given_a_parking_lot_when_park_a_car_then_I_can_pick_a_car()
        {
            var p = new ParkingLot(1);
            var car = new Car("car");

            var carId = p.Park(car);

            Assert.AreSame(car, p.Pick(carId));
        }

        [TestMethod]
        public void given_a_parking_lot_when_parking_two_car_then_I_can_pick_all_of_them()
        {
            var p = new ParkingLot(2);
            var firstCar = new Car("Car One");
            var secondCar = new Car("Second One");

            var firstCarId = p.Park(firstCar);
            var secondCarId = p.Park(secondCar);

            Assert.AreSame(firstCar, p.Pick(firstCarId));
            Assert.AreSame(secondCar, p.Pick(secondCarId));
        }

        [TestMethod]
        public void given_a_parking_lot_when_parking_a_car_then_I_can_only_pick_one()
        {
            var p = new ParkingLot(1);
            var myCar = new Car("my own car is unique");

            var myCarId = p.Park(myCar);
            Assert.AreSame(myCar, p.Pick(myCarId));

            Assert.IsNull(p.Pick(myCarId));
        }

        [TestMethod]
        public void given_a_parking_lot_when_not_parking_a_car_then_I_can_not_pick_a_car()
        {
            var p = new ParkingLot(1);
            var notParkedCar = new Car("car");

            Assert.IsNull(p.Pick(notParkedCar.Id));
        }

        [TestMethod]
        public void given_a_parking_lot_with_no_empty_space_when_parking_a_car_then_I_can_not_park()
        {
            var p = new ParkingLot(0);
            var car = new Car("car");

            var carId = p.Park(car);

            Assert.IsNull(carId);
        }

        [TestMethod]
        public void given_a_parking_lot_with_one_space_when_I_park_the_first_car_and_pick_the_first_car_then_I_can_park_the_second_one ()
        {
            var p = new ParkingLot(1);
            var firstCar = new Car("first car");
            var secondCar = new Car("second car");

            var firstCarId = p.Park(firstCar);
            var pickedFirstCar = p.Pick(firstCarId);
            var secondCarId = p.Park(secondCar);

            Assert.AreSame(firstCar, pickedFirstCar);
            Assert.AreSame(secondCar, p.Pick(secondCarId));
        }
    }
}
