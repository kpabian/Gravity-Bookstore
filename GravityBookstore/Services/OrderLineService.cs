﻿using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class OrderLineService : IOrderLineService
    {
        private readonly IOrderLineRepository _orderLineRepository;
        private readonly IMapper _mapper;
        public OrderLineService(IOrderLineRepository orderLineRepository, IMapper mapper)
        {
            _orderLineRepository = orderLineRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await _orderLineRepository.DeleteOrderLine(id);
            return result;
        }

        public async Task<List<OrderLineDto>> Get(int id)
        {
            var result = await _orderLineRepository.Get(id);
            var mappedResult = _mapper.Map<List<OrderLineDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(OrderLinePostDto orderLine)
        {
            var mappedOrderLine = _mapper.Map<Order_line>(orderLine);
            var result = await _orderLineRepository.CreateOrderLine(mappedOrderLine);
            return result;
        }

        public async Task<bool> Put(OrderLinePostDto orderLine, int id)
        {
            var mappedOrderLine = _mapper.Map<Order_line>(orderLine);
            var result = await _orderLineRepository.UpdateOrderLine(mappedOrderLine, id);
            return result;
        }
    }
}
