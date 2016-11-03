namespace OOBootCamp
{
    public class SmartParkingBoy
    {
        private readonly ParkingLot parkingLot;

        public SmartParkingBoy(ParkingLot parkingLot)
        {
            this.parkingLot = parkingLot;
        }

        public Car Pick(string carId)
        {
            return parkingLot.Pick(carId);
        }

        public string Park(Car car)
        {
            return parkingLot.Park(car);
        }
    }
}