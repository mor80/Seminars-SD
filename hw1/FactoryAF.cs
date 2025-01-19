namespace hw1;

public class FactoryAF
{
    public Queue<Car> Cars { get; private set; }
    public List<Customer> Customers { get; private set; }
    
    public FactoryAF(List<Customer> customers)
    {
        Customers = customers;
        Cars = new Queue<Car>();
    }

    public void SaleCar()
    {
        foreach (var customer in Customers)
        {
            if (customer.Car != null) 
                break;

            customer.Car = Cars.Count > 0 ? Cars.Dequeue() : null;
        }
        
        Customers = Customers.Where(x => x.Car != null).ToList();
        Cars.Clear();
    }

    public void AddCar()
    {
        Cars.Enqueue(new Car(Cars.Count + 1));
    }
}