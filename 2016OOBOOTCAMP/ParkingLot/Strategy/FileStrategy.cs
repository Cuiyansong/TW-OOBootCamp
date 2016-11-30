using System;

namespace ParkingLot.Strategy
{
    public class FileStrategy : IOutPutStrategy
    {
        public string Write(string input)
        {
            Console.Write(input);
            return input;
        }
    }
}