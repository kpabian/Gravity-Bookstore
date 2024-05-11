using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace GravityBookstore.Repositories;

public class AddressRepository : IAddressRepository
{

    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public AddressRepository(AppDbContext context, ILogger<AddressRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateAddress(Address address)
    {
        await _context.Addresses.AddAsync(address);
        await _context.SaveChangesAsync();
        return address.Address_id;
    }

    public async Task<bool> DeleteAddress(int addressId)
    {
        Address? existingAddress = await _context.Addresses.FindAsync(addressId);
        if (existingAddress is null)
        {
            return false;
        }
        _context.Addresses.Remove(existingAddress);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Address>> Get(int? id)
    {
        IQueryable<Address> query = _context.Addresses.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Address_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateAddress(Address address, int addressId)
    {
        var existingAddress = await _context.Addresses.FindAsync(addressId);
        if (existingAddress is null)
        {
            return false;
        }
        existingAddress.Address_id = address.Address_id;
        existingAddress.Street_number = address.Street_number;
        existingAddress.Street_name = address.Street_name;
        existingAddress.City = address.City;
        existingAddress.Country_id = address.Country_id;
        existingAddress.Country = address.Country;

        await _context.SaveChangesAsync();
        return true;

    }
}
