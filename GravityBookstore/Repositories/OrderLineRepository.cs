using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
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
        IQueryable<Order_line> query = _context.OrderLines.AsQueryable();
        Order_line? existingOrderLine = await query.FirstOrDefaultAsync(x => x.Line_id == id);
        if (existingOrderLine is null)
        {
            return false;
        }
        _context.OrderLines.Remove(existingOrderLine);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Order_line>> Get(int? id)
    {
        IQueryable<Order_line> query = _context.OrderLines.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Line_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateOrderLine(Order_line orderLine, int id)
    {
        IQueryable<Order_line> query = _context.OrderLines.AsQueryable();
        Order_line? existingOrderLine = await query.FirstOrDefaultAsync(x => x.Line_id == id);
        if (existingOrderLine is null)
        {
            return false;
        }
        existingOrderLine.Line_id = orderLine.Line_id;
        existingOrderLine.Cust_order_id = orderLine.Cust_order_id;
        existingOrderLine.Cust_order = orderLine.Cust_order;
        existingOrderLine.Book_id = orderLine.Book_id;
        existingOrderLine.Price = orderLine.Price;
        await _context.SaveChangesAsync();
        return true;
    }
}
