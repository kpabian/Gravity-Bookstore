using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using System.Net;

namespace GravityBookstore.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public CustomerRepository(AppDbContext context, ILogger<CustomerRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateCustomer(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
        return customer.Customer_id;
    }

    public async Task<bool> DeleteCustomer(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Customer>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateCustomer(Customer customer, int id)
    {
        throw new NotImplementedException();
    }
}
