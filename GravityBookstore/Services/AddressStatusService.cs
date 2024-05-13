using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class AddressStatusService : IAddressStatusService
    {
        private readonly IAddressStatusRepository _addressStatusRepository;
        private readonly IMapper _mapper;
        public AddressStatusService(IAddressStatusRepository addressStatusRepository, IMapper mapper)
        {
            _addressStatusRepository = addressStatusRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await _addressStatusRepository.DeleteAddressStatus(id);
            return result;
        }

        public async Task<List<AddressStatusDto>> Get(int id)
        {
            var result = await _addressStatusRepository.Get(id);
            var mappedResult = _mapper.Map<List<AddressStatusDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(AddressStatusPostDto addressStatus)
        {
            var mappedAddressStatus = _mapper.Map<Address_status>(addressStatus);
            var result = await _addressStatusRepository.CreateAddressStatus(mappedAddressStatus);
            return result;
        }

        public async Task<bool> Put(AddressStatusPostDto addressStatus, int id)
        {
            var mappedAddressStatus = _mapper.Map<Address_status>(addressStatus);
            var result = await _addressStatusRepository.UpdateAddressStatus(mappedAddressStatus, id);
            return result;
        }
    }
}
