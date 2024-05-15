using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;

namespace GravityBookstore.Repositories;


public class CustomerAddressRepository : ICustomerAddressRepository
{
    private readonly AppDbContext _context;

    public CustomerAddressRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Customer_address> CreateCustomerAddress(Customer_address customerAddress)
    {
        await _context.CustomerAddresses.AddAsync(customerAddress);
        await _context.SaveChangesAsync();
        return customerAddress;
    }

}


