using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
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
            var result = await _countryRepository.DeleteCountry(id);
            return result;
        }

        public async Task<List<CountryDto>> Get(int id)
        {
            var result = await _countryRepository.Get(id);
            var mappedResult = _mapper.Map<List<CountryDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Country country)
        {
            var result = await _countryRepository.CreateCountry(country);
            return result;
        }

        public async Task<bool> Put(Country country, int id)
        {
            var result = await _countryRepository.UpdateCountry(country, id);
            return result;
        }
    }
}
