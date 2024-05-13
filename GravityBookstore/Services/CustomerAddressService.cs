using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services;

public class CustomerAddressService(ICustomerAddressRepository customerAddressRepository, IMapper mapper) : ICustomerAddressService
{
    private readonly ICustomerAddressRepository _customerAddressRepository = customerAddressRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<bool> Delete(int id)
    {
        var result = await _customerAddressRepository.DeleteCustomerAddress(id);
        return result;
    }

    public async Task<List<CustomerAddressDto>> Get(int CustId, int AddressId)
    {
        var result = await _customerAddressRepository.Get(CustId, AddressId);
        var mappedResult = _mapper.Map<List<CustomerAddressDto>>(result);
        return mappedResult;
    }

    public async Task<(int, int)> Post(Customer_address customerAddress)
    {
        var result = await _customerAddressRepository.CreateCustomerAddress(customerAddress);
        return result;
    }

    public async Task<bool> Put(Customer_address customerAddress, int id)
    {
        var result = await _customerAddressRepository.UpdateCustomerAddress(customerAddress, id);
        return result;
    }
}
