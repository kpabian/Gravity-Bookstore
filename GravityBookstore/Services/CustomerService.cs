using GravityBookstore.IRepositories;
using GravityBookstore.IServices;

namespace GravityBookstore.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

    }
}
