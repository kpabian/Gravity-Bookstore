using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IOrderLineRepository
{
    Task<List<Order_line>> Get(int? id);
    Task<int> CreateOrderLine(Order_line orderLine);
    Task<bool> UpdateOrderLine(Order_line orderLine, int id);
    Task<bool> DeleteOrderLine(int id);
}
