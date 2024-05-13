using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
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
        Customer_address? existingCustAddress = await _context.CustomerAddresses.FindAsync(id);
        if (existingCustAddress is null)
        {
            return false;
        }
        _context.CustomerAddresses.Remove(existingCustAddress);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Customer_address>> Get(int? CustId, int? AddressId)
    {
        IQueryable<Customer_address> query = _context.CustomerAddresses.AsQueryable();

        if (CustId != null)
        {
            query = query.Where(x => x.Customer_id == CustId);
        }
        if (AddressId != null)
        {
            query = query.Where(x => x.Address_id == AddressId);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateCustomerAddress(Customer_address customerAddress, int id)
    {
        IQueryable<Customer_address> query = _context.CustomerAddresses.AsQueryable();
        Customer_address? existingCustAddress = await query.FirstOrDefaultAsync(x => x.Address_id == id);
        if (existingCustAddress is null)
        {
            return false;
        }
        existingCustAddress.Customer_id = customerAddress.Customer_id;
        existingCustAddress.Address_id = customerAddress.Address_id;
        await _context.SaveChangesAsync();
        return true;
    }

}
