using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.Services;

public class AddressService(IAddressRepository addressRepository, IMapper mapper) : IAddressService
{
    private readonly IAddressRepository _addressRepository = addressRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<bool> Delete(int id)
    {
        var result = await _addressRepository.DeleteAddress(id);
        return result;
    }

    public async Task<List<AddressDto>> Get(int id)
    {
        var result = await _addressRepository.Get(id);
        var mappedResult = _mapper.Map<List<AddressDto>>(result);
        return mappedResult;
    }

    public async Task<int> Post(AddressPostDto address)
    {
        var mappedAddress = _mapper.Map<Address>(address);
        var result = await _addressRepository.CreateAddress(mappedAddress);
        return result;
    }

    public async Task<bool> Put(AddressPostDto address, int id)
    {
        var mappedAddress = _mapper.Map<Address>(address);
        var result = await _addressRepository.UpdateAddress(mappedAddress, id);
        return result;
    }
}
