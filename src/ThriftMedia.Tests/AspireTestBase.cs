using System;

namespace ThriftMedia.Tests;

public abstract class AspireTestBase
{
    /// <summary>
    /// Sets up the test environment for a distributed Aspire application.
    /// </summary>
    /// <param name="resourceName">The name of the resource (service) to test against.</param>
    /// <returns>A tuple containing an HttpClient for the resource and the running app instance.</returns>
    protected async Task<(HttpClient client, IAsyncDisposable app)> SetupTestEnvironment(string resourceName)
    {
        // Validate input
        if (string.IsNullOrWhiteSpace(resourceName))
            throw new ArgumentException("Resource name must not be null, empty, or whitespace.", nameof(resourceName));

        // Create the distributed application host for the ThriftMedia_AppHost project
        var appHost = await DistributedApplicationTestingBuilder.CreateAsync<Projects.ThriftMedia_AppHost>();

        // Build the distributed application
        var app = await appHost.BuildAsync();

        // Start the distributed application
        await app.StartAsync();

        // Create an HttpClient for the specified resource (service)
        var httpClient = app.CreateHttpClient(resourceName);

        // Simple delay to allow services to start (replace with proper health check if needed)
        await Task.Delay(TimeSpan.FromSeconds(5));

        // Return the HttpClient and the running app instance for use in tests
        return (httpClient, app);
    }
}
