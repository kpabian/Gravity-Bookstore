using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace GravityBookstore.Repositories;

public class AddressStatusRepository : IAddressStatusRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public AddressStatusRepository(AppDbContext context, ILogger<AddressStatusRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateAddressStatus(Address_status addressStatus)
    {
        await _context.AddressStatuses.AddAsync(addressStatus);
        await _context.SaveChangesAsync();
        return addressStatus.Status_id;
    }

    public async Task<bool> DeleteAddressStatus(int id)
    {
        Address_status? existingAddressStatus = await _context.AddressStatuses.FindAsync(id);
        if (existingAddressStatus is null)
        {
            return false;
        }
        _context.AddressStatuses.Remove(existingAddressStatus);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Address_status>> Get(int? id)
    {
        IQueryable<Address_status> query = _context.AddressStatuses.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Status_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateAddressStatus(Address_status addressStatus, int id)
    {
        var existingAddressStatus = await _context.AddressStatuses.FindAsync(id);
        if (existingAddressStatus is null)
        {
            return false;
        }
        existingAddressStatus.Status_id = addressStatus.Status_id;
        existingAddressStatus.Status_value = addressStatus.Status_value;

        await _context.SaveChangesAsync();
        return true;
    }
}
