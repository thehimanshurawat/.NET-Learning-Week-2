using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StudentManagementTests
{
    public class StudentIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public StudentIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetStudents_ReturnsSuccess()
        {
            var response = await _client.GetAsync("/api/student");
            response.EnsureSuccessStatusCode();
        }
    }
}
