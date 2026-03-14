using FluentAssertions;
using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace EventProcessor.UnitTests;

public class IngestionContractTests(WebApplicationFactory<Program> factory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task Post_Event_WithEmptyId_ShouldReturnBadRequest()
    {
        // Arrange
        var invalidEvent = new
        {
            Id = Guid.Empty,
            Timestamp = DateTime.UtcNow,
            Source = "Test-Source",
            EventType = "Test-Type",
            Payload = new { value = 10 }
        };

        // Act
        var response = await _client.PostAsJsonAsync("/api/v1/events", invalidEvent);

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }
}