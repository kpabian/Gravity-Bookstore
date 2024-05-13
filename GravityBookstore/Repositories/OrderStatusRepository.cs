using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GravityBookstore.Repositories;

public class OrderStatusRepository : IOrderStatusRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public OrderStatusRepository(AppDbContext context, ILogger<OrderStatusRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateOrderStatus(Order_status orderStatus)
    {
        await _context.OrderStatuses.AddAsync(orderStatus);
        await _context.SaveChangesAsync();
        return orderStatus.Status_id;
    }

    public async Task<bool> DeleteOrderStatus(int id)
    {
        IQueryable<Order_status> query = _context.OrderStatuses.AsQueryable();
        Order_status? existingOrderStatus = await query.FirstOrDefaultAsync(x => x.Status_id == id);
        if (existingOrderStatus is null)
        {
            return false;
        }
        _context.OrderStatuses.Remove(existingOrderStatus);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Order_status>> Get(int? id)
    {
        IQueryable<Order_status> query = _context.OrderStatuses.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Status_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateOrderStatus(Order_status orderStatus, int id)
    {
        IQueryable<Order_status> query = _context.OrderStatuses.AsQueryable();
        Order_status? existingOrderStatus = await query.FirstOrDefaultAsync(x => x.Status_id == id);
        if (existingOrderStatus is null)
        {
            return false;
        }
        existingOrderStatus.Status_id = orderStatus.Status_id;
        existingOrderStatus.Status_value = orderStatus.Status_value;
        return true;
    }
}
