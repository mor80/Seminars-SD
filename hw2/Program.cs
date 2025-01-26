using hw1;
using hw1.Abstraction;
using hw2.Entities;

namespace hw2;

internal class Program
{
    static void Main(string[] args)
    {
        var customerStorage = new CustomerStorage();

        var customers = new[]
        {
            new Customer(name: "Ivan", legStrength: 10, handStrength: 1),
            new Customer(name : "Petr", legStrength : 1, handStrength : 10),
            new Customer(name : "Sidr", legStrength : 1, handStrength : 1),
            new Customer(name : "Sidr", legStrength : 10, handStrength : 10),
        };

        foreach (var customer in customers)
            customerStorage.AddCustomer(customer);

        var pedalCarFactory = new PedalCarFactory();
        var handCarFactory = new HandCarFactory();

        var carStorage = new CarService();

        carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 2));
        carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 3));
        carStorage.AddCar(handCarFactory, EmptyEngineParams.Empty);
        carStorage.AddCar(handCarFactory, EmptyEngineParams.Empty);

        var hseCarShop = new HseCarService(carStorage, customerStorage);

        Console.WriteLine("=== Покупатели ===");
        foreach (var customer in customers)
            Console.WriteLine(customer);

        Console.WriteLine("\n=== Продажа автомобилей ===\n");
        hseCarShop.SellCars();

        Console.WriteLine("=== Покупатели ===");
        foreach (var customer in customers)
            Console.WriteLine(customer);
    }
}