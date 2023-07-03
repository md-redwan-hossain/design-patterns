using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Components;

public class OfficeProcessor : IProcessor
{
    public void RunStressTest()
    {
        Console.WriteLine("Running Stress test of Office Processor...");
        Console.WriteLine("Completed.");
    }
}