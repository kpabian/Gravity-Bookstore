using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

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
            throw new NotImplementedException();
        }

        public async Task<List<Book_language>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Post(Book_language bookLanguage)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(Book_language bookLanguage, int id)
        {
            throw new NotImplementedException();
        }
    }
}
