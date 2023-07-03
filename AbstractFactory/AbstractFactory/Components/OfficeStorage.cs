using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Components;

public class OfficeStorage : IStorage
{
    public int Capacity { get; set; }

    public void RunHealthCheck()
    {
        Console.WriteLine("Running Health check of Office Storage...");
        Console.WriteLine("Completed.");
    }
}