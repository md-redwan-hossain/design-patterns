using AbstractFactory.Components;
using AbstractFactory.Components.Interfaces;
using AbstractFactory.Factory.Interfaces;


namespace AbstractFactory.Factory;

internal abstract class GamingPcFactory : IPcFactory
{
    public static IProcessor CreateProcessor()
    {
        return new GamingProcessor();
    }

    public static IStorage CreateStorage()
    {
        return new GamingStorage();
    }
}