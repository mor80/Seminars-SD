using hw1.Abstraction;

namespace hw1;

public class HandEngine : IEngine
{
    public EngineType Type => EngineType.Hand;
    
    public bool IsCompatible(Customer customer)
    {
        return customer.HandStrength > 5;
    }
    
    public override string ToString() => $"Тип: {Type}";
}