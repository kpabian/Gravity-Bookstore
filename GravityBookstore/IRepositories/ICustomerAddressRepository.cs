using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface ICustomerAddressRepository
{
    Task<List<Customer_address>> Get(int? id);
    Task<(int, int)> CreateCustomerAddress(Customer_address customerAddress);
    Task<bool> UpdateCustomerAddress(Customer_address customerAddress, int id);
    Task<bool> DeleteCustomerAddress(int id);
}
