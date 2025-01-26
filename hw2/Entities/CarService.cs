using hw1;
using hw1.Abstraction;
using hw2.Entities.Abstraction;

namespace hw2.Entities;

public class CarService : ICarProvider
{
    private readonly LinkedList<Car> _cars = new();
    
    public void AddCar<TParams>(ICarFactory<TParams> carFactory, TParams carParams)
        where TParams : EngineParamsBase
    {
        var car = carFactory.CreateCar(carParams);
        _cars.AddLast(car);
    }

    public Car? GetCar(EngineType engineType)
    {
        var car = _cars.FirstOrDefault(car => car.Engine.Type == engineType);

        if (car != null)
            _cars.Remove(car);

        return car;
    }   
}