using hw1.Abstraction;

namespace hw1;

public class PedalEngine : IEngine
{
    public int Size { get; set; }
    public EngineType Type => EngineType.Pedal;

    public PedalEngine(int size)
    {
        Size = size;
    }
    
    public bool IsCompatible(Customer customer)
    {
        return customer.LegStrength > 5;
    }

    public override string ToString() => $"Тип: {Type}, Размер педалей: {Size}";
}