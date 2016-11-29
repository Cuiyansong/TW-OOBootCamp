namespace ParkingLot
{
    public interface IParking : IParkable
    {
        int Capacity { get; }
    }

    public interface IParkable
    {
        Car Pick(string id);
        bool IsParkingLotFull { get; }
        int EmptySpaceCount { get; }
        string Park(Car parkedCar);
    }
}