using hw1;
using hw1.Abstraction;

namespace hw2.Entities.Abstraction;

public interface ICarProvider
{
    Car? GetCar(EngineType engineType);
}