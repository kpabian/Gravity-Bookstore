using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface ICustOrderService
{
    Task<List<Cust_order>> Get(int id);
    Task<int> Post(Cust_order custOrder);
    Task<bool> Put(Cust_order custOrder, int id);
    Task<bool> Delete(int id);
}
