using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class OrderHistoryRepository : IOrderHistoryRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public OrderHistoryRepository(AppDbContext context, ILogger<OrderHistoryRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateOrderHistory(Order_history orderHistory)
    {
        await _context.OrderHistories.AddAsync(orderHistory);
        await _context.SaveChangesAsync();
        return orderHistory.History_id;
    }

    public async Task<bool> DeleteOrderHistory(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Order_history>> Get(int? id)
    {
        IQueryable<Order_history> query = _context.OrderHistories.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.History_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateOrderHistory(Order_history orderHistory, int id)
    {
        throw new NotImplementedException();
    }
}
