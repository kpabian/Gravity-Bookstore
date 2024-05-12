using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface ICountryService
{
    Task<List<CountryDto>> Get(int id);
    Task<int> Post(Country country);
    Task<bool> Put(Country country, int id);
    Task<bool> Delete(int id);
}
