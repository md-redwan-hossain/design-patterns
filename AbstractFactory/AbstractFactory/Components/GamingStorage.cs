using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Components;

public class GamingStorage : IStorage
{
    public void RunHealthCheck()
    {
        Console.WriteLine("Running Health check of Gaming Storage...");
        Console.WriteLine("Completed.");
    }
}