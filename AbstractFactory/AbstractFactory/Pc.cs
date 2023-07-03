using AbstractFactory.Components.Interfaces;
using AbstractFactory.Factory.Interfaces;

namespace AbstractFactory;

public class Pc
{
    public IProcessor Processor;
    public IStorage Storage;

    public Pc(IPcFactory pcFactory)
    {
        this.Processor = pcFactory.CreateProcessor();
        this.Storage = pcFactory.CreateStorage();
    }
}