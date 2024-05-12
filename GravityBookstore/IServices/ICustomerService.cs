using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface ICustomerService
{
    Task<List<Customer>> Get(int id);
    Task<int> Post(Customer customer);
    Task<bool> Put(Customer customer, int id);
    Task<bool> Delete(int id);

}
