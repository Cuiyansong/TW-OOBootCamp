namespace OOBootCamp
{
    public interface IParking
    {
        Car Pick(string id);
        string Park(Car parkedCar);
        bool IsParkingLotFull { get; }
    }
}