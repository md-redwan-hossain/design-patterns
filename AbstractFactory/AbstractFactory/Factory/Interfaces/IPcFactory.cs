using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Factory.Interfaces;

public interface IPcFactory

{
    public IProcessor CreateProcessor();
    public IStorage CreateStorage();
}