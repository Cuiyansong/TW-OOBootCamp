using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParkingLot.Tests
{
    [TestClass]
    public class ParkingDirectorFacts
    {
        [TestMethod]
        public void given_a_parking_manager_with_one_space_parking_lot_managed_by_a_parking_director_then_director_could_print_right_report()
        {
            var ooParkingLot = new OOParkingLot(1);
            var parkingDirector = new ParkingDirector(new ParkingManager(ooParkingLot));

            var report = parkingDirector.GetReport();
            
            Assert.AreEqual("M 1 0\r\n\tP 1 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_empty_space_parking_lot_managed_by_a_parking_director_then_director_could_print_right_report()
        {
            var ooParkingLot = new OOParkingLot(1);
            var parkingManager = new ParkingManager(ooParkingLot);
            var parkingDirector = new ParkingDirector(parkingManager);
            parkingManager.Park(new Car("car"));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 0 1\r\n\tP 0 1", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_two_parking_lot_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var firstParkingLot = new OOParkingLot(1);
            var secondParkingLot = new OOParkingLot(0);
            var parkingDirector = new ParkingDirector(new ParkingManager(firstParkingLot, secondParkingLot));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 1 0\r\n\tP 1 0\r\n\tP 0 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_a_parking_boy_with_a_parking_lot_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var ooParkingLot = new OOParkingLot(1);
            var parkingBoy = new ParkingBoy(new OOParkingLot(1));
            var parkingDirector = new ParkingDirector(new ParkingManager(ooParkingLot, parkingBoy));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 2 0\r\n\tP 1 0\r\n\tB0 1 0\r\n\t\tP 1 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_a_smart_parking_boy_with_a_parking_lot_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var ooParkingLot = new OOParkingLot(1);
            var smartParkingBoy = new SmartParkingBoy(new OOParkingLot(1));
            var parkingDirector = new ParkingDirector(new ParkingManager(ooParkingLot, smartParkingBoy));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 2 0\r\n\tP 1 0\r\n\tB1 1 0\r\n\t\tP 1 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_a_super_parking_boy_with_a_parking_lot_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var ooParkingLot = new OOParkingLot(1);
            var superParkingBoy = new SuperParkingBoy(new OOParkingLot(1));
            var parkingDirector = new ParkingDirector(new ParkingManager(ooParkingLot, superParkingBoy));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 2 0\r\n\tP 1 0\r\n\tB2 1 0\r\n\t\tP 1 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_a_super_parking_boy_with_a_parking_lot_and_a_smart_boy_with_a_parking_lot_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var superParkingBoy = new SuperParkingBoy(new OOParkingLot(1));
            var smartParkingBoy = new SmartParkingBoy(new OOParkingLot(1));
            var parkingDirector = new ParkingDirector(new ParkingManager(smartParkingBoy, superParkingBoy));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 2 0\r\n\tB1 1 0\r\n\t\tP 1 0\r\n\tB2 1 0\r\n\t\tP 1 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_a_super_parking_boy_with_two_parking_lot_and_a_smart_boy_with_a_parking_lot_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var superParkingBoy = new SuperParkingBoy(new OOParkingLot(1), new OOParkingLot(1));
            var smartParkingBoy = new SmartParkingBoy(new OOParkingLot(1));
            var parkingDirector = new ParkingDirector(new ParkingManager(smartParkingBoy, superParkingBoy));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 3 0\r\n\tB1 1 0\r\n\t\tP 1 0\r\n\tB2 2 0\r\n\t\tP 1 0\r\n\t\tP 1 0", report);
        }

        [TestMethod]
        public void given_a_parking_manager_with_a_super_parking_boy_with_two_parking_lot_and_a_smart_boy_with_a_parking_lot_which_parked_a_car_managed_by_a_parking_director_then_the_director_could_print_right_report()
        {
            var superParkingBoy = new SuperParkingBoy(new OOParkingLot(1), new OOParkingLot(1));
            var smartBoyParkingLot = new OOParkingLot(1);
            var smartParkingBoy = new SmartParkingBoy(smartBoyParkingLot);
            var parkingDirector = new ParkingDirector(new ParkingManager(smartParkingBoy, superParkingBoy));
            smartBoyParkingLot.Park(new Car("car"));

            var report = parkingDirector.GetReport();

            Assert.AreEqual("M 2 1\r\n\tB1 0 1\r\n\t\tP 0 1\r\n\tB2 2 0\r\n\t\tP 1 0\r\n\t\tP 1 0", report);
        }
    }
}
