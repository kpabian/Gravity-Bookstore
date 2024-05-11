using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface ICustOrderRepository
{
    Task<List<Cust_order>> Get(int? id);
    Task<int> CreateCustOrder(Cust_order custOrder);
    Task<bool> UpdateCustOrder(Cust_order custOrder, int id);
    Task<bool> DeleteCustOrder(int id);
}
