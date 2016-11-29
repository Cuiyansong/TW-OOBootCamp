namespace ParkingLot.Tests
{
    public class ParkingManager : ParkingBoyBase<IParkable>
    {
        public ParkingManager(params IParkable[] parkingLot)
            : base(parkingLot)
        {
        }
    }
}