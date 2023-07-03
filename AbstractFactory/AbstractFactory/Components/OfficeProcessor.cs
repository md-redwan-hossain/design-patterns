using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Components;

public class OfficeProcessor : IProcessor
{
    public int CoreCount { get; set; }

    public void RunStressTest()
    {
        Console.WriteLine("Running Stress test of Office Processor...");
        Console.WriteLine("Completed.");
    }
}