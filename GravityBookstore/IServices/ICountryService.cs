using GravityBookstore.Models;

namespace GravityBookstore.IServices;

public interface ICountryService
{
    Task<List<Country>> Get(int id);
    Task<int> Post(Country country);
    Task<bool> Put(Country country, int id);
    Task<bool> Delete(int id);
}
