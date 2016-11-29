namespace ParkingLot
{
    public class ParkingBoy: ParkingBoyBase<IParkingLot>
    {
        public ParkingBoy(params IParkingLot[] parkingLotLot)
            : base(parkingLotLot)
        {
            
        }
    }
}