using AbstractFactory.Components;
using AbstractFactory.Components.Interfaces;
using AbstractFactory.Factory.Interfaces;

namespace AbstractFactory.Factory;

internal class OfficePcFactory : IPcFactory
{
    public IProcessor CreateProcessor()
    {
        return new OfficeProcessor();
    }

    public IStorage CreateStorage()
    {
        return new OfficeStorage();
    }
}