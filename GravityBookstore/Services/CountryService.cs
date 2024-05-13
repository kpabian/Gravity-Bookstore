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

        public async Task<int> Post(CountryPostDto country)
        {
            var mappedCountry = _mapper.Map<Country>(country);
            var result = await _countryRepository.CreateCountry(mappedCountry);
            return result;
        }

        public async Task<bool> Put(CountryPostDto country, int id)
        {
            var mappedCountry = _mapper.Map<Country>(country);
            var result = await _countryRepository.UpdateCountry(mappedCountry, id);
            return result;
        }
    }
}
