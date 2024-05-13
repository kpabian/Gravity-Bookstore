using GravityBookstore;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Text;
using System.Text.Json;

namespace IntegrationTests;

public class AuthorIntegrationTest
{
    private readonly WebApplicationFactory<Program> webApplicationFactory;
    private readonly string path = "/api/Author";

    public AuthorIntegrationTest()
    {
        webApplicationFactory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Get_AuthorStatusReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var response = await client.GetAsync($"{path}?id=5");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Contains("author_id", responseString);
    }

    [Fact]
    public async Task Post_AuthorReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new 
        {
            author_name = "John Doe"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(path, content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(int.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Put_AuthorReturnOk()
    {
        var client = webApplicationFactory.CreateClient();
        var body = JsonSerializer.Serialize(new
        {
            author_name = "A. Walton Litz"
        });
        var content = new StringContent(body, Encoding.UTF8, "application/json");
        var response = await client.PutAsync($"{path}/5", content);

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.True(bool.TryParse(responseString, out _));
    }

    [Fact]
    public async Task Delete_AuthorReturnOk()
    {
        int? toDelete;
        {
            var client = webApplicationFactory.CreateClient();
            var body = JsonSerializer.Serialize(new
            {
                author_name = "John Doe"
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