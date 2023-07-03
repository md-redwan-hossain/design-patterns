using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Components;

public class GamingProcessor : IProcessor
{
    public void RunStressTest()
    {
        Console.WriteLine("Running Stress test of Gaming Processor...");
        Console.WriteLine("Completed.");
    }
}