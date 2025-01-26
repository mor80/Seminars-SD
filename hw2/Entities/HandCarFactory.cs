using hw1;
using hw1.Abstraction;

namespace hw2.Entities;

public class HandCarFactory : ICarFactory<EmptyEngineParams>
{
    public Car CreateCar(EmptyEngineParams carParams)
    {
        var engine = new HandEngine();
        return new Car(new Random().Next(1, 100), engine);
    }
}