using ParkingLot.Tests;

namespace ParkingLot
{
    public class ParkingDirector
    {
        private readonly ParkingManager parkingManager;

        public ParkingDirector(ParkingManager parkingManager)
        {
            this.parkingManager = parkingManager;
        }

        public string OutPutByStrategy(IOutPutStrategy strategy = null)
        {
            var report = parkingManager.BuildReport();
            return strategy == null ? report : strategy.Write(report);
        }
    }
}