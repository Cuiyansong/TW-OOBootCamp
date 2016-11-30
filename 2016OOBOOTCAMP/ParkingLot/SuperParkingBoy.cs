using System.Linq;
using System.Text;

namespace ParkingLot
{
    public class SuperParkingBoy: ParkingBoyBase<IParkingLot>
    {
        public SuperParkingBoy(params IParkingLot[] parkingLotLot)
            : base(parkingLotLot)
        {
        }

        protected override float OrderFunc(IParkingLot parkingLotLot)
        {
            return (float) parkingLotLot.EmptySpaceCount / parkingLotLot.Capacity;
        }

        public override string Name
        {
            get { return "B2"; }
        }
    }
}