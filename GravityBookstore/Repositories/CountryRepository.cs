using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using System.Net;

namespace GravityBookstore.Repositories;

public class CountryRepository : ICountryRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _log;

    public CountryRepository(AppDbContext context, ILogger<CountryRepository> log)
    {
        _context = context;
        _log = log;
    }

    public async Task<int> CreateCountry(Country country)
    {
        await _context.Countries.AddAsync(country);
        await _context.SaveChangesAsync();
        return country.Country_id;
    }

    public async Task<bool> DeleteCountry(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Country>> Get(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateCountry(Country country, int id)
    {
        throw new NotImplementedException();
    }
}
