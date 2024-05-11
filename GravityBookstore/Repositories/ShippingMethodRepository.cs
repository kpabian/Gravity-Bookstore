using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
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
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateShippingMethod(Shipping_method shippingMethod, int id)
    {
        throw new NotImplementedException();
    }
}
