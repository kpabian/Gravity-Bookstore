using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
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
        throw new NotImplementedException();
    }

    public async Task<List<Order_status>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateOrderStatus(Order_status orderStatus, int id)
    {
        throw new NotImplementedException();
    }
}
