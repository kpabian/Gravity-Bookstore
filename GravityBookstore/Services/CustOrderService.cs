using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class CustOrderService : ICustOrderService
    {
        private readonly ICustOrderRepository _custOrderRepository;
        private readonly IMapper _mapper;
        public CustOrderService(ICustOrderRepository custOrderRepository, IMapper mapper)
        {
            _custOrderRepository = custOrderRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await _custOrderRepository.DeleteCustOrder(id);
            return result;
        }
        public async Task<List<CustOrderDto>> Get(int id)
        {
            var result = await _custOrderRepository.Get(id);
            var mappedResult = _mapper.Map<List<CustOrderDto>>(result);
            return mappedResult;
        }
        
        public async Task<List<OrderedBooksDto>> GetBooks(string language) {
            var result = await _custOrderRepository.GetBooks(language);
            return result;
        }

        public async Task<int> Post(CustOrderPostDto custOrder)
        {
            var mappedCustOrder = _mapper.Map<Cust_order>(custOrder);
            var result = await _custOrderRepository.CreateCustOrder(mappedCustOrder);
            return result;
        }

        public async Task<bool> Put(CustOrderPostDto custOrder, int id)
        {
            var mappedCustOrder = _mapper.Map<Cust_order>(custOrder);
            var result = await _custOrderRepository.UpdateCustOrder(mappedCustOrder, id);
            return result;
        }
    }
}
