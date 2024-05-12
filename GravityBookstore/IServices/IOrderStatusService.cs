using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IOrderStatusService
{
    Task<List<Order_status>> Get(int id);
    Task<int> Post(Order_status orderStatus);
    Task<bool> Put(Order_status orderStatus, int id);
    Task<bool> Delete(int id);
}
