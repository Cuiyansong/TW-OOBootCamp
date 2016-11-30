using System;

namespace ParkingLot.Strategy
{
    public class ConsoleStrategy: IOutPutStrategy
    {
        public string Write(string input)
        {
            Console.Write(input);
            return input;
        }
    }
}