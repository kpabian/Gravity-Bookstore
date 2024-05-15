using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace IntegrationTests;


internal class WebAppFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
{
    // protected override void ConfigureWebHost(IWebHostBuilder builder)
    // {
    //     base.ConfigureWebHost(builder);

    //     builder.ConfigureTestServices(services =>
    //     {
    //         var dbContextDescriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));
    //         services.Remove(dbContextDescriptor);

    //         var dbConnectionDescriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbConnection));
    //         services.Remove(dbConnectionDescriptor);
        
    //     });
    // }
}
