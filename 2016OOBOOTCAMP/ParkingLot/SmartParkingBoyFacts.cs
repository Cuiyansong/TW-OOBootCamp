using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOBootCamp
{
    [TestClass]
    public class SmartParkingBoyFacts
    {
        [TestMethod]
        public void given_a_parkinglot_and_a_smart_boy_and_park_a_car_when_smart_boy_pick_the_car_then_the_car_can_pick()
        {
            var parkingLot = new ParkingLot(1);
            var car = new Car("car");
            var carId = parkingLot.Park(car);

            var pickedCar = new SmartParkingBoy(parkingLot).Pick(carId);

            Assert.AreSame(car, pickedCar);
        }

        [TestMethodAttribute]
        public void given_a_parkinglot_and_a_smart_boy_when_smart_boy_park_car_then_parkinglot_pick_the_car()
        {
            var parkingLot = new ParkingLot(2);

            var car = new Car("car");
            var carId = new SmartParkingBoy(parkingLot).Park(car);

            Assert.AreSame(car, parkingLot.Pick(carId));
        }
    }
}