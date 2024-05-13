using GravityBookstore;
using GravityBookstore.ModelsDto;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Text;
using System.Text.Json;

namespace IntegrationTests;

public class AddressStatusIntegrationTest
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;
    private readonly string path = "/api/AddressStatus";

    public AddressStatusIntegrationTest()
    {
        webApplicationFactory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Get_AddressStatusReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync($"{path}?id=2");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Contains("status_id", responseString);
    }

    [Fact]
    public async Task Post_AddressReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new 
        {
            status_value = "New"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(path, content);

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
            status_value = "Inactive"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PutAsync($"{path}/2", content);

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
                status_value = "Old"
            });
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(path, content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            toDelete = int.Parse(responseString);
        }
        Assert.NotNull(toDelete);
        {
            var client = webApplicationFactory.CreateClient();
            var response = await client.DeleteAsync($"{path}/{toDelete}");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Assert.True(bool.TryParse(responseString, out _));
        }
    }
}