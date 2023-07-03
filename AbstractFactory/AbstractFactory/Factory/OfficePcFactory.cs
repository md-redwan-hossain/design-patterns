using AbstractFactory.Components;
using AbstractFactory.Components.Interfaces;
using AbstractFactory.Factory.Interfaces;

namespace AbstractFactory.Factory;

internal abstract class OfficePcFactory : IPcFactory
{
    public static IProcessor CreateProcessor()
    {
        return new OfficeProcessor();
    }

    public static IStorage CreateStorage()
    {
        return new OfficeStorage();
    }
}