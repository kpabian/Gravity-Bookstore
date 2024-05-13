using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

namespace GravityBookstore.Services
{
    public class BookLanguageService : IBookLanguageService
    {
        private readonly IBookLanguageRepository _bookLanguageRepository;
        private readonly IMapper _mapper;

        public BookLanguageService(IBookLanguageRepository bookLanguageRepository, IMapper mapper)
        {
            _bookLanguageRepository = bookLanguageRepository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            var delete = await _bookLanguageRepository.DeleteBookLanguage(id);
            return delete;
        }

        public async Task<List<BookLanguageDto>> Get(int id)
        {
            var result = await _bookLanguageRepository.Get(id);
            var mappedResult = _mapper.Map<List<BookLanguageDto>>(result);
            return mappedResult;
        }

        public async Task<int> Post(BookLanguagePostDto bookLanguage)
        {
            var mappedBookLanguage = _mapper.Map<Book_language>(bookLanguage);
            var result = await _bookLanguageRepository.CreateBookLanguage(mappedBookLanguage);
            return result;
        }

        public async Task<bool> Put(BookLanguagePostDto bookLanguage, int id)
        {
            var mappedBookLanguage = _mapper.Map<Book_language>(bookLanguage);
            var result = await _bookLanguageRepository.UpdateBookLanguage(mappedBookLanguage, id);
            return result;
        }
    }
}
