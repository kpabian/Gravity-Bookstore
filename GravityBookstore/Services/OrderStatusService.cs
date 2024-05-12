using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class OrderStatusService : IOrderStatusService
    {
        private readonly IOrderStatusRepository _orderStatusRepository;
        private readonly IMapper _mapper;
        public OrderStatusService(IOrderStatusRepository orderStatusRepository, IMapper mapper)
        {
            _orderStatusRepository = orderStatusRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderStatusDto>> Get(int id)
        {
            var result = await _orderStatusRepository.Get(id);
            var mappedResult = _mapper.Map<List<OrderStatusDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(Order_status orderStatus)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Order_status orderStatus, int id)
        {
            throw new NotImplementedException();
        }
    }
}
