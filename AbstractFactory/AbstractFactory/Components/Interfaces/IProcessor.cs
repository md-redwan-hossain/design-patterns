namespace AbstractFactory.Components.Interfaces;

public interface IProcessor
{
    public int CoreCount { get; set; }
    public void RunStressTest();
}