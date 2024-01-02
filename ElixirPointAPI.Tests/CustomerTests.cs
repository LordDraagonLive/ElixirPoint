using Microsoft.AspNetCore.Mvc.Testing;

namespace ElixirPoint.API.Tests;

public class CustomerTests : IClassFixture<WebApplicationFactory<ApiTestEntryPoint>>
{
    private readonly WebApplicationFactory<ApiTestEntryPoint> _factory;

    public CustomerTests(WebApplicationFactory<ApiTestEntryPoint> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Get_EndpointReturnsSuccessAndCorrectContentType()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/api/customer");

        response.EnsureSuccessStatusCode();
        Assert.Equal("application/json; charset=utf-8",
                     response.Content.Headers.ContentType.ToString());
    }
}
