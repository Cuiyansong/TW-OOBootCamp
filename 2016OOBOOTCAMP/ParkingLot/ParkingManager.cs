using System.Linq;
using System.Text;

namespace ParkingLot
{
    public class ParkingManager : ParkingBoyBase<IParkable>
    {
        public ParkingManager(params IParkable[] parkingLot)
            : base(parkingLot)
        {
        }

        public override string Name
        {
            get { return "M"; }
        }

        public override string Prefix
        {
            get { return "\t"; }
        }
    }
}