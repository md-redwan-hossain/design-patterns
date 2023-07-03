namespace AbstractFactory.Components.Interfaces;

public interface IStorage
{
    public int Capacity { get; set; }
    public void RunHealthCheck();
}