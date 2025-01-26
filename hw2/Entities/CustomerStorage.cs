using hw1;
using hw2.Entities.Abstraction;

namespace hw2.Entities;

public class CustomerStorage : ICustomersProvider
{
    public List<Customer> Customers { get; } = new();
    
    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public IEnumerable<Customer> GetCustomers() => Customers.Where(customer => customer.Car == null);
}