using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using System.Net;

namespace GravityBookstore.Repositories;

public class CustOrderRepository : ICustOrderRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public CustOrderRepository(AppDbContext context, ILogger<CustOrderRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateCustOrder(Cust_order custOrder)
    {
        await _context.Orders.AddAsync(custOrder);
        await _context.SaveChangesAsync();
        return custOrder.Order_id;
    }

    public async Task<bool> DeleteCustOrder(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Cust_order>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateCustOrder(Cust_order custOrder, int id)
    {
        throw new NotImplementedException();
    }
}
