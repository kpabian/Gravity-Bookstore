using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface IAddressStatusRepository
{
    Task<List<Address_status>> Get(int? id);
    Task<int> CreateAddressStatus(Address_status addressStatus);
    Task<bool> UpdateAddressStatus(Address_status addressStatus, int id);
    Task<bool> DeleteAddressStatus(int id);
}
