namespace ParkingLot
{
    public class ParkingDirector
    {
        private readonly ParkingManager parkingManager;

        public ParkingDirector(ParkingManager parkingManager)
        {
            this.parkingManager = parkingManager;
        }

        public string GetReport()
        {
            return this.parkingManager.GetReport();
        }
    }
}