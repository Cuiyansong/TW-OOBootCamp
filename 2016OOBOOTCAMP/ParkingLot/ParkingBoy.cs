using System.Linq;
using System.Text;

namespace ParkingLot
{
    public class ParkingBoy : ParkingBoyBase<IParkingLot>
    {
        public ParkingBoy(params IParkingLot[] parkingLotLot)
            : base(parkingLotLot)
        {
        }

        public override string Name
        {
            get { return "B0"; }
        }
    }
}