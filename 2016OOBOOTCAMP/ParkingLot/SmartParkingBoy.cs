namespace ParkingLot
{
    public class SmartParkingBoy : ParkingBoyBase<IParking>
    {
        public SmartParkingBoy(params IParking[] parkingLot)
            : base(parkingLot)
        {
        }
    }
}