using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOBootCamp
{
    [TestClass]
    public class SuperParkingBoyFacts : ParkingLotFacts
    {
        [TestMethod]
        public void given_a_parkingLot_and_a_super_parking_boy_when_super_boy_park_a_car_then_the_car_in_the_parkingLot()
        {
            var firstParkinglot = new ParkingLot(1);
            var superParkingBoy = new SuperParkingBoy(new List<ParkingLot> {firstParkinglot});
            var car = new Car("car");

            var carId = superParkingBoy.Park(car);

            Assert.AreSame(car, firstParkinglot.Pick(carId));
        }

        [TestMethod]
        public void given_a_parkingLot_and_a_super_parking_boy_when_super_park_a_car_then_super_boy_pick_the_car_in_the_parkingLot()
        {
            var firstParkinglot = new ParkingLot(1);
            var superParkingBoy = new SuperParkingBoy(new List<ParkingLot> { firstParkinglot });
            var car = new Car("car");
            var carId = superParkingBoy.Park(car);

            Assert.AreSame(car, superParkingBoy.Pick(carId));
        }

        [TestMethod]
        public void given_two_parkinglot_and_the_first_()
        {
            var firstPrakingLot = new ParkingLot(4);
            var secondPrakingLot = new ParkingLot(3);


        }
    }

    public class SuperParkingBoy
    {
        private readonly List<ParkingLot> parkingLots;

        public SuperParkingBoy(List<ParkingLot> parkingLots)
        {
            this.parkingLots = parkingLots;
        }

        public string Park(Car car)
        {
           return this.parkingLots[0].Park(car);
        }

        public Car Pick(string carId)
        {
            return this.parkingLots[0].Pick(carId);
        }
    }
}