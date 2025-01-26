namespace hw1.Abstraction;

public class PedalCarFactory : ICarFactory<PedalEngineParams>
{
    public Car CreateCar(PedalEngineParams carParams)
    {
        var engine = new PedalEngine(carParams.PedalSize);
        return new Car(new Random().Next(1, 100), engine);
    }
}