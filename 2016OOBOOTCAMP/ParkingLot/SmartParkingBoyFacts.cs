using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOBootCamp
{
    [TestClass]
    public class SmartParkingBoyFacts : ParkingLotFacts
    {
        [TestMethod]
        public void given_two_parkingLot_with_same_space_and_a_smart_parking_boy_when_smart_boy_park_a_car_then_the_car_in_the_first_parkingLot()
        {
            var firstParkinglot = new ParkingLot(1);
            var secondParkinglot = new ParkingLot(1);

            var smartParkingBoy = new SmartParkingBoy(new List<ParkingLot> {firstParkinglot, secondParkinglot});
            var car = new Car("car");
            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, firstParkinglot.Pick(carId));
        }

        [TestMethod]
        public void given_first_parkingLot_with_one_space_and_second_parkingLot_with_two_space_and_a_smart_parking_boy_when_smart_boy_park_a_car_then_the_car_in_the_second_parkingLot()
        {
            var firstParkinglot = new ParkingLot(2);
            var secondParkinglot = new ParkingLot(2);
            var parkedCar = new Car("parked car");
            firstParkinglot.Park(parkedCar);

            var smartParkingBoy = new SmartParkingBoy(new List<ParkingLot> { firstParkinglot, secondParkinglot });
            var car = new Car("car");
            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, secondParkinglot.Pick(carId));
        }

        [TestMethod]
        public void given_first_parkingLot_with_two_space_and_second_parkingLot_with_one_space_and_a_smart_parking_boy_when_smart_boy_park_a_car_then_the_car_in_the_first_parkingLot()
        {
            var firstParkinglot = new ParkingLot(2);
            var secondParkinglot = new ParkingLot(2);
            var parkedCar = new Car("parked car");
            secondParkinglot.Park(parkedCar);

            var smartParkingBoy = new SmartParkingBoy(new List<ParkingLot> { firstParkinglot, secondParkinglot });
            var car = new Car("car");
            var carId = smartParkingBoy.Park(car);

            Assert.AreSame(car, firstParkinglot.Pick(carId));
        }
    }
}