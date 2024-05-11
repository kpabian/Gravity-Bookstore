using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using System.Net;

namespace GravityBookstore.Repositories;

public class OrderLineRepository : IOrderLineRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public OrderLineRepository(AppDbContext context, ILogger<OrderLineRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateOrderLine(Order_line orderLine)
    {
        await _context.OrderLines.AddAsync(orderLine);
        await _context.SaveChangesAsync();
        return orderLine.Line_id;
    }

    public async Task<bool> DeleteOrderLine(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Order_line>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateOrderLine(Order_line orderLine, int id)
    {
        throw new NotImplementedException();
    }
}
