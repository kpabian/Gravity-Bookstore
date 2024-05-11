using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IAddressRepository
{
    Task<List<Address>> Get(int? id);
    Task<int> CreateAddress(Address address);
    Task<bool> UpdateAddress(Address address, int addressId);
    Task<bool> DeleteAddress(int addressId);
}
