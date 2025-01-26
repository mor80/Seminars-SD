namespace hw1.Abstraction;

public enum EngineType
{
    Pedal,
    Hand
}

public interface IEngine
{
    bool IsCompatible(Customer customer);
    EngineType Type { get; }
}