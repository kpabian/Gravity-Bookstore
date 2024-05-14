using GravityBookstore;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Text;
using System.Text.Json;

namespace IntegrationTests;

public class OrderStatusIntegrationTest
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public OrderStatusIntegrationTest()
    {
        webApplicationFactory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Get_OrderStatusReturnNotFound()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/OrderStatus");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Get_OrderStatusReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/OrderStatus?id=1");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Contains("status_id", responseString);
    }

    [Fact]
    public async Task Post_OrderStatuseReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            status_value = "test"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("/api/OrderStatus", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(int.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Put_OrderStatusReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            status_value = "test"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PutAsync("/api/OrderStatus/1", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(bool.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Delete_OrderStatusReturnOk()
    {
        int? toDelete;
        {
            var client = webApplicationFactory.CreateClient();
            var body = JsonSerializer.Serialize(new
            {
                status_value = "test"

            });
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/OrderStatus", content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            toDelete = int.Parse(responseString);
        }
        Assert.NotNull(toDelete);
        {
            var client = webApplicationFactory.CreateClient();
            var response = await client.DeleteAsync($"/api/OrderStatus/{toDelete}");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Assert.True(bool.TryParse(responseString, out _));
        }
    }
}