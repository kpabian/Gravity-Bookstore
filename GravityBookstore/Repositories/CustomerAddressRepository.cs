using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using System.Net;

namespace GravityBookstore.Repositories;

public class  CustomerAddressRepository : ICustomerAddressRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public CustomerAddressRepository(AppDbContext context, ILogger<CustomerAddressRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<(int, int)> CreateCustomerAddress(Customer_address customerAddress)
    {
        await _context.CustomerAddresses.AddAsync(customerAddress);
        await _context.SaveChangesAsync();
        return (customerAddress.Customer_id, customerAddress.Address_id);
    }

    public async Task<bool> DeleteCustomerAddress(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Customer_address>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateCustomerAddress(Customer_address customerAddress, int id)
    {
        throw new NotImplementedException();
    }

}
