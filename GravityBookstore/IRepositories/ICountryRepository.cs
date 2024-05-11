using GravityBookstore.Models;

namespace GravityBookstore.IRepositories;

public interface ICountryRepository
{
    Task<List<Country>> Get(int? id);
    Task<int> CreateCountry(Country country);
    Task<bool> UpdateCountry(Country country, int id);
    Task<bool> DeleteCountry(int id);
}
