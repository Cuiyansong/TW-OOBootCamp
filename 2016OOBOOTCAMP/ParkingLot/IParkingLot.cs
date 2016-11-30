namespace ParkingLot
{
    public interface IOutPutStrategy
    {
        string Write(string input);
    }

    public interface IParkingLot : IParkable
    {

    }

    public interface IParkable: IReport
    {
        Car Pick(string id);
        int EmptySpaceCount { get; }
        string Park(Car parkedCar); 
        int Capacity { get; }
    }

    public interface IReport
    {
        string BuildReport();
        string Name { get; }
        string Prefix { get; }
    }
}