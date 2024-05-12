using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IOrderLineService
{
    Task<List<Order_line>> Get(int id);
    Task<int> Post(Order_line orderLine);
    Task<bool> Put(Order_line orderLine, int id);
    Task<bool> Delete(int id);
}
