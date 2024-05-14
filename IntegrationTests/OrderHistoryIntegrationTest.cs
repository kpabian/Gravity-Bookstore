using GravityBookstore;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Text;
using System.Text.Json;

namespace IntegrationTests;

public class OrderHistoryIntegrationTest
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public OrderHistoryIntegrationTest()
    {
        webApplicationFactory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Get_OrderHistoryReturnNotFound()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/OrderHistory");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Get_OrderHistoryReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/OrderHistory?id=3");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Contains("history_id", responseString);
    }

    [Fact]
    public async Task Post_OrderHistoryReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            cust_order_id = 45757,
            status_id = 1,
            status_date = "2024-05-14"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("/api/OrderHistory", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(int.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Put_OrderHistoryReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            cust_order_id = 45756,
            status_id = 1,
            status_date = "2024-05-14"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PutAsync("/api/OrderHistory/1", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(bool.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Delete_OrderHistoryReturnOk()
    {
        int? toDelete;
        {
            var client = webApplicationFactory.CreateClient();
            var body = JsonSerializer.Serialize(new
            {
                cust_order_id = 45756,
                status_id = 1,
                status_date = "2024-05-14"

            });
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/OrderHistory", content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            toDelete = int.Parse(responseString);
        }
        Assert.NotNull(toDelete);
        {
            var client = webApplicationFactory.CreateClient();
            var response = await client.DeleteAsync($"/api/OrderHistory/{toDelete}");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Assert.True(bool.TryParse(responseString, out _));
        }
    }
}