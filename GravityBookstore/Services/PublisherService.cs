using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;
        public PublisherService(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await _publisherRepository.DeletePublisher(id);
            return result;
        }

        public async Task<List<PublisherDto>> Get(int id)
        {
            var result = await _publisherRepository.Get(id);
            var mappedResult = _mapper.Map<List<PublisherDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(PublisherPostDto publisher)
        {
            var mappedPublisher = _mapper.Map<Publisher>(publisher);
            var result = await _publisherRepository.CreatePublisher(mappedPublisher);
            return result;
        }

        public async Task<bool> Put(PublisherPostDto publisher, int id)
        {
            var mappedPublisher = _mapper.Map<Publisher>(publisher);
            var result = await _publisherRepository.UpdatePublisher(mappedPublisher, id);
            return result;
        }
    }
}
