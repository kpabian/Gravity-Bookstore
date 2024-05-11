
using GravityBookstore.DB;
using GravityBookstore.IRepositories;
using GravityBookstore.IServices;
using GravityBookstore.Repositories;
using GravityBookstore.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GravityBookstore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
           
            builder.Services.AddDbContext<AppDbContext>();

            //AutoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Services
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<IAddressStatusService, AddressStatusService>();
            builder.Services.AddScoped<IAuthorService, AuthorService>();
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IBookAuthorService, BookAuthorService>();
            builder.Services.AddScoped<IBookLanguageService, BookLanguageService>();
            builder.Services.AddScoped<ICountryService, CountryService>();
            builder.Services.AddScoped<ICustomerAddressService, CustomerAddressService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<ICustOrderService, CustOrderService>();
            builder.Services.AddScoped<IOrderHistoryService, OrderHistoryService>();
            builder.Services.AddScoped<IOrderLineService, OrderLineService>();
            builder.Services.AddScoped<IOrderStatusService, OrderStatusService>();
            builder.Services.AddScoped<IPublisherService, PublisherService>();
            builder.Services.AddScoped<IShippingMethodService, ShippingMethodService>();

            //Repositories
            builder.Services.AddScoped<IAddressRepository, AddressRepository>();
            builder.Services.AddScoped<IAddressStatusRepository, AddressStatusRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IBookAuthorRepository, BookAuthorRepository>();
            builder.Services.AddScoped<IBookLanguageRepository, BookLanguageRepository>();
            builder.Services.AddScoped<ICountryRepository, CountryRepository>();
            builder.Services.AddScoped<ICustomerAddressRepository, CustomerAddressRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustOrderRepository, CustOrderRepository>();
            builder.Services.AddScoped<IOrderHistoryRepository, OrderHistoryRepository>();
            builder.Services.AddScoped<IOrderLineRepository, OrderLineRepository>();
            builder.Services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
            builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();
            builder.Services.AddScoped<IShippingMethodRepository, ShippingMethodRepository>();



            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.MapType<Stream>(() => new OpenApiSchema { Type = "file", Format = "binary" });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });

                options.OperationFilter<SecurityRequirementsOperationFilter>();

                options.ExampleFilters();

                options.CustomSchemaIds(type =>
                {
                    return type.Name switch
                    {
                        _ => type.Name
                    };
                });

            });

            builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                        builder.Configuration.GetSection("AppSettings:Token").Value!))
                };
                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var token = context.Request.Headers["Authorization"].FirstOrDefault();

                        if (!string.IsNullOrEmpty(token))
                        {
                            if (token.StartsWith("Bearer "))
                            {
                                token = token.Substring("Bearer ".Length);
                            }
                            context.Token = token;
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gravity Bookstore Api V1");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
