using GravityBookstore;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Text;
using System.Text.Json;

namespace IntegrationTests;

public class ShippingMethodIntegrationTest
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;

    public ShippingMethodIntegrationTest()
    {
        webApplicationFactory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Get_ShippingMethodReturnNotFound()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/ShippingMethod");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Get_ShippingMethodReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync("/api/ShippingMethod?id=1");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Contains("method_id", responseString);
    }

    [Fact]
    public async Task Post_ShippingMethodReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            method_name = "string",
            cost = 0
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("/api/ShippingMethod", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(int.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Put_ShippingMethodReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            method_name = "string",
            cost = 0
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PutAsync("/api/ShippingMethod/1", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(bool.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Delete_ShippingMethodReturnOk()
    {
        int? toDelete;
        {
            var client = webApplicationFactory.CreateClient();
            var body = JsonSerializer.Serialize(new
            {
                method_name = "string",
                cost = 0

            });
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/ShippingMethod", content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            toDelete = int.Parse(responseString);
        }
        Assert.NotNull(toDelete);
        {
            var client = webApplicationFactory.CreateClient();
            var response = await client.DeleteAsync($"/api/ShippingMethod/{toDelete}");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Assert.True(bool.TryParse(responseString, out _));
        }
    }
}