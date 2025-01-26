using hw1.Abstraction;

namespace hw1;

public class Car
{
    public int Number { get; set; }

    public IEngine Engine { get; }

    public Car(int number, IEngine engine)
    {
        Engine = engine;
        Number = number;
    }
    
    public bool IsCompatible(Customer customer)
    {
        return Engine.IsCompatible(customer);
    }

    public override string ToString() => $"Номер: {Number}, Двигатель: {{ {Engine} }}";

}