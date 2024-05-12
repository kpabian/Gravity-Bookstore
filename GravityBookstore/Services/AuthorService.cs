using AutoMapper;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;
using GravityBookstore.Repositories;

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

    public async Task<List<AuthorDto>> Get(int id)
    {
        var result = await _authorRepository.Get(id);
        var mappedResult = _mapper.Map<List<AuthorDto>>(result);
        return mappedResult;
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
