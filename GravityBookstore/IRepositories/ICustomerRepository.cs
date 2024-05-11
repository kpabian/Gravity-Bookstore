using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface ICustomerRepository
{
    Task<List<Customer>> Get(int? id);
    Task<int> CreateCustomer(Customer customer);
    Task<bool> UpdateCustomer(Customer customer, int id);
    Task<bool> DeleteCustomer(int id);
}
