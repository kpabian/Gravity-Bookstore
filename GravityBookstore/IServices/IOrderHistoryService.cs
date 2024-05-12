using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IOrderHistoryService
{
    Task<List<Order_history>> Get(int id);
    Task<int> Post(Order_history orderHistory);
    Task<bool> Put(Order_history orderHistory, int id);
    Task<bool> Delete(int id);
}
