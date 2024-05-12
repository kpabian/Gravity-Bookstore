using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface IAddressStatusService
{
    Task<List<Address_status>> Get(int id);
    Task<int> Post(Address_status addressStatus);
    Task<bool> Put(Address_status addressStatus, int id);
    Task<bool> Delete(int id);
}
