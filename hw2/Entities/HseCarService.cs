using hw1;
using hw1.Abstraction;
using hw2.Entities.Abstraction;

namespace hw2.Entities;

public class HseCarService
{
    private readonly ICarProvider _carProvider;

    private readonly ICustomersProvider _customersProvider;
    
    public HseCarService(ICarProvider carProvider, ICustomersProvider customersProvider)
    {
        _carProvider = carProvider;
        _customersProvider = customersProvider;
    }

    public void SellCars()
    {
        var customers = _customersProvider.GetCustomers();

        foreach (var customer in customers)
        {
            if (customer.Car != null)
                continue;

            var suitableEngineType = DetermineEngineType(customer);

            if (!suitableEngineType.HasValue)
                continue;

            var car = _carProvider.GetCar(suitableEngineType.Value);

            if (car == null)
                continue;

            customer.Car = car;
        }
    }

    private static EngineType? DetermineEngineType(Customer customer)
    {
        if (customer.LegStrength > 5)
            return EngineType.Pedal;

        if (customer.HandStrength > 5)
            return EngineType.Hand;

        return null;
    }
}