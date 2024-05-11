using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IOrderStatusRepository
{
    Task<List<Order_status>> Get(int? id);
    Task<int> CreateOrderStatus(Order_status orderStatus);
    Task<bool> UpdateOrderStatus(Order_status orderStatus, int id);
    Task<bool> DeleteOrderStatus(int id);
}
