namespace ParkingLot
{
    public class SuperParkingBoy: ParkingBoyBase<IParking>
    {
        public SuperParkingBoy(params IParking[] parkingLot)
            : base(parkingLot)
        {
        }

        protected override float OrderFunc(IParking parkingLot)
        {
            return (float) parkingLot.EmptySpaceCount / parkingLot.Capacity;
        }
    }
}