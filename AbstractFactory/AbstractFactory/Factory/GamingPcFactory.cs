using AbstractFactory.Components;
using AbstractFactory.Components.Interfaces;
using AbstractFactory.Factory.Interfaces;

namespace AbstractFactory.Factory;

internal class GamingPcFactory : IPcFactory
{
    public IProcessor CreateProcessor()
    {
        return new GamingProcessor();
    }

    public IStorage CreateStorage()
    {
        return new GamingStorage();
    }
}