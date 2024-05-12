using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;
        public CountryService(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Country>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Country country)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Country country, int id)
        {
            throw new NotImplementedException();
        }
    }
}
