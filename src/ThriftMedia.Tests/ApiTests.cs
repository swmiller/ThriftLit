using System;

namespace ThriftMedia.Tests;

public class ApiTests : AspireTestBase
{
    private const string ThriftMediaApiResourceName = "thriftmediaapi";
    private const string MediaEndpoint = "/media";

    /// <summary>
    /// Tests that the GET /media endpoint returns HTTP 200 OK.
    /// </summary>
    [Fact]
    public async Task GetAllMedia_ReturnsOk()
    {
        // Arrange: Set up the test environment and get an HttpClient for the thriftmediaapi service
        var setupResult = await SetupTestEnvironment(ThriftMediaApiResourceName);
        var httpClient = setupResult.client;
        await using var app = setupResult.app; // Ensures the app is disposed after the test

        // Act: Send a GET request to the /media endpoint
        var response = await httpClient.GetAsync(MediaEndpoint);

        // Assert: Verify that the response status code is 200 OK
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}
