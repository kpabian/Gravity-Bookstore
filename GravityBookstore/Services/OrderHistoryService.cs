using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        private readonly IOrderHistoryRepository _orderHistoryRepository;
        private readonly IMapper _mapper;
        public OrderHistoryService(IOrderHistoryRepository orderHistoryRepository, IMapper mapper)
        {
            _orderHistoryRepository = orderHistoryRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await _orderHistoryRepository.DeleteOrderHistory(id);
            return result;
        }

        public async Task<List<OrderHistoryDto>> Get(int id)
        {
            var result = await _orderHistoryRepository.Get(id);
            var mappedResult = _mapper.Map<List<OrderHistoryDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(OrderHistoryPostDto orderHistory)
        {
            var mappedOrderHistory = _mapper.Map<Order_history>(orderHistory);
            var result = await _orderHistoryRepository.CreateOrderHistory(mappedOrderHistory);
            return result;
        }

        public async Task<bool> Put(OrderHistoryPostDto orderHistory, int id)
        {
            var mappedOrderHistory = _mapper.Map<Order_history>(orderHistory);
            var result = await _orderHistoryRepository.UpdateOrderHistory(mappedOrderHistory, id);
            return result;
        }
    }
}
