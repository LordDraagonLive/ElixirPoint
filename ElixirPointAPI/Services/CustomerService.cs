using ElixirPointAPI.Models;

namespace ElixirPointAPI.Services;

class CustomerService
{
    private readonly Dictionary<int, Customer> _customers = new();

    public void Create(Customer? customer)
    {
        if (customer is null)
        {
            return;
        }

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

    public void Update(Customer customer)
    {
        var existingCustomer = GetById(customer.Id);

        if (existingCustomer != null)
        {
            return;
        }

        _customers[customer.Id] = customer;
    }

    public void Delete(int id)
    {
        _customers.Remove(id);
    }
}
