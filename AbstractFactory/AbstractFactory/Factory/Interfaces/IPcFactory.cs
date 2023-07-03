using AbstractFactory.Components.Interfaces;

namespace AbstractFactory.Factory.Interfaces;

public interface IPcFactory

{
    public static abstract IProcessor CreateProcessor();
    public static abstract IStorage CreateStorage();
}