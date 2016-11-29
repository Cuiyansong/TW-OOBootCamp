namespace ParkingLot
{
    public class ParkingBoy: ParkingBoyBase<IParking>
    {
        public ParkingBoy(params IParking[] parkingLot)
            : base(parkingLot)
        {
            
        }
    }
}