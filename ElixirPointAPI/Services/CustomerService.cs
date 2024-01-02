using ElixirPoint.API.Models;

namespace ElixirPoint.API.Services;

interface ICustomerService
{
    Task Create(Customer? customer);
    Task Delete(int id);
    List<Customer> GetAll();
    Customer? GetById(int id);
    Task Update(Customer customer);
}

class CustomerService : ICustomerService
{
    private readonly Dictionary<int, Customer> _customers = new();

    public async Task Create(Customer? customer)
    {
        if (customer is null)
        {
            return;
        }
        await Task.Delay(100);

        _customers[customer.Id] = customer;
    }

    public Customer? GetById(int id)
    {
        return _customers.GetValueOrDefault(id);
    }

    public List<Customer> GetAll()
    {
        return _customers.Values.ToList();
    }

    public async Task Update(Customer customer)
    {
        var existingCustomer = GetById(customer.Id);

        if (existingCustomer != null)
        {
            return;
        }

        _customers[customer.Id] = customer;
    }

    public async Task Delete(int id)
    {
        _customers.Remove(id);
    }
}
