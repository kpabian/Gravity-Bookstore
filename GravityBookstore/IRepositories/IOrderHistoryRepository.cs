using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IOrderHistoryRepository
{
    Task<List<Order_history>> Get(int? id);
    Task<int> CreateOrderHistory(Order_history orderHistory);
    Task<bool> UpdateOrderHistory(Order_history orderHistory, int id);
    Task<bool> DeleteOrderHistory(int id);
}
