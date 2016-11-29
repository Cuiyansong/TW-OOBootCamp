namespace ParkingLot
{
    public class SmartParkingBoy : ParkingBoyBase<IParkingLot>
    {
        public SmartParkingBoy(params IParkingLot[] parkingLotLot)
            : base(parkingLotLot)
        {
        }
    }
}