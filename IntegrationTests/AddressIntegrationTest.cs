using GravityBookstore;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Text;
using System.Text.Json;

namespace IntegrationTests;

public class AddressIntegrationTest
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public AddressIntegrationTest()
    {
        webApplicationFactory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Get_AddressReturnNotFound()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/Address");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Get_AddressReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/Address?id=5");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Contains("address_id", responseString);
    }

    [Fact]
    public async Task Post_AddressReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            street_number = "123",
            street_name = "Main St",
            city = "Springfield",
            country_id = 1
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("/api/Address", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(int.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Put_AddressReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            street_number = "123",
            street_name = "Main St",
            city = "Springfield",
            country_id = 1
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PutAsync("/api/Address/5", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(bool.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Delete_AddressReturnOk()
    {
        int? toDelete;
        {
            var client = webApplicationFactory.CreateClient();
            var body = JsonSerializer.Serialize(new
            {
                street_number = "123",
                street_name = "Main St",
                city = "Springfield",
                country_id = 1
            });
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Address", content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            toDelete = int.Parse(responseString);
        }
        Assert.NotNull(toDelete);
        {
            var client = webApplicationFactory.CreateClient();
            var response = await client.DeleteAsync($"/api/Address/{toDelete}");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Assert.True(bool.TryParse(responseString, out _));
        }
    }
}