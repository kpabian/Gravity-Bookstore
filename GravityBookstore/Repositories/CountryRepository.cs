using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.Models;
using Microsoft.EntityFrameworkCore;
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
        Country? existingCountry = await _context.Countries.FindAsync(id);
        if (existingCountry is null)
        {
            return false;
        }
        _context.Countries.Remove(existingCountry);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Country>> Get(int? id)
    {
        IQueryable<Country> query = _context.Countries.AsQueryable();

        if (id != null)
        {
            query = query.Where(x => x.Country_id == id);
        }

        var result = await query.ToListAsync().ConfigureAwait(false);
        return result;
    }

    public async Task<bool> UpdateCountry(Country country, int id)
    {
        throw new NotImplementedException();
    }
}
