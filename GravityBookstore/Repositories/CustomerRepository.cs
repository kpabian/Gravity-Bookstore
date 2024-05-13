using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
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
        IQueryable<Customer> query = _context.Customers.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Customer_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateCustomer(Customer customer, int id)
    {
        throw new NotImplementedException();
    }
}
