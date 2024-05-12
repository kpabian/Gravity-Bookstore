using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;

namespace GravityBookstore.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IMapper _mapper;
    public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
    {
        _authorRepository = authorRepository;
        _mapper = mapper;
    }
    public async Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Author>> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<int> Post(Author author)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Put(Author author, int id)
    {
        throw new NotImplementedException();
    }
}
