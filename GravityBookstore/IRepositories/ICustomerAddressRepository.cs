using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface ICustomerAddressRepository
{
    Task<Customer_address> CreateCustomerAddress(Customer_address customerAddress);
}
