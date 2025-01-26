using hw2.Entities;

namespace hw1.Abstraction;

public interface ICarFactory<TParams>
    where TParams : EngineParamsBase

{
    Car CreateCar(TParams parameters);
}