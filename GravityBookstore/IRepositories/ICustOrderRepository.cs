using GravityBookstore.ModelsDto;
using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface ICustOrderRepository
{
    Task<List<Cust_order>> Get(int? id);
    Task<List<OrderedBooksDto>> GetBooks(string language);
    Task<int> CreateCustOrder(Cust_order custOrder);
    Task<bool> UpdateCustOrder(Cust_order custOrder, int id);
    Task<bool> DeleteCustOrder(int id);
}
