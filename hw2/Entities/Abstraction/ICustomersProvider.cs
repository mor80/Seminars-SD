using hw1;

namespace hw2.Entities.Abstraction;

public interface ICustomersProvider
{
    IEnumerable<Customer> GetCustomers();
}