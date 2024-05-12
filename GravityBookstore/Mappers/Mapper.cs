using AutoMapper;
using GravityBookstore.Models;
using GravityBookstore.ModelsDto;

namespace GravityBookstore.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Address, AddressDto>();
            CreateMap<Address_status, AddressStatusDto>();
            CreateMap<Author, AuthorDto>();
            CreateMap<Book, BookDto>();
            CreateMap<Book_author, BookAuthorDto>();
            CreateMap<Book_language, BookLanguageDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Customer_address, CustomerAddressDto>();
            CreateMap<Cust_order, CustOrderDto>();
            CreateMap<Order_history, OrderHistoryDto>();
            CreateMap<Order_line, OrderLineDto>();
            CreateMap<Order_status, OrderStatusDto>();
            CreateMap<Shipping_method, ShippingMethodDto>();
            CreateMap<Publisher, PublisherDto>();


        }
    }
}
