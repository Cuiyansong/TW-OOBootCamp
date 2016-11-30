using System.Linq;
using System.Text;

namespace ParkingLot
{
    public class SmartParkingBoy : ParkingBoyBase<IParkingLot>
    {
        public SmartParkingBoy(params IParkingLot[] parkingLotLot)
            : base(parkingLotLot)
        {
        }

        public override string Name
        {
            get { return "B1"; }
        }
    }
}