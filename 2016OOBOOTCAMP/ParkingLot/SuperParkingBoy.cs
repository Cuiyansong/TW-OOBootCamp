using System.Linq;
using System.Text;

namespace ParkingLot
{
    public class SuperParkingBoy: ParkingBoyBase<IParkingLot>, IReport
    {
        public SuperParkingBoy(params IParkingLot[] parkingLotLot)
            : base(parkingLotLot)
        {
        }

        protected override float OrderFunc(IParkingLot parkingLotLot)
        {
            return (float) parkingLotLot.EmptySpaceCount / parkingLotLot.Capacity;
        }

        public string GetReport()
        {
            var output = new StringBuilder();
            var totalEmptySpaceCount = this.ParkingLots.Sum(x => x.EmptySpaceCount);
            var totalCapacity = this.ParkingLots.Sum(x => x.Capacity);

            output.Append(string.Format("{0} {1} {2}", GetName(), totalEmptySpaceCount, totalCapacity - totalEmptySpaceCount));
            foreach (var item in ParkingLots)
            {
                output.Append(System.Environment.NewLine);
                output.Append("\t\t" + item.GetReport());
            }

            return output.ToString();
        }

        public string GetName()
        {
            return "B2";
        }
    }
}