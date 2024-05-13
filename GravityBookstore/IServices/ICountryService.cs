using GravityBookstore.Models;
using GravityBookstore.ModelsDto;


namespace GravityBookstore.IServices;

public interface ICountryService
{
    Task<List<CountryDto>> Get(int id);
    Task<int> Post(CountryPostDto country);
    Task<bool> Put(CountryPostDto country, int id);
    Task<bool> Delete(int id);
}
