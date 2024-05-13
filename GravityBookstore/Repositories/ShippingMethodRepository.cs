using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class ShippingMethodRepository : IShippingMethodRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public ShippingMethodRepository(AppDbContext context, ILogger<ShippingMethodRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateShippingMethod(Shipping_method shippingMethod)
    {
        await _context.ShippingMethods.AddAsync(shippingMethod);
        await _context.SaveChangesAsync();
        return shippingMethod.Method_id;
    }

    public async Task<bool> DeleteShippingMethod(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Shipping_method>> Get(int? id)
    {
        IQueryable<Shipping_method> query = _context.ShippingMethods.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Method_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateShippingMethod(Shipping_method shippingMethod, int id)
    {
        throw new NotImplementedException();
    }
}
