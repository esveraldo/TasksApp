using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Text;

namespace TasksApp.Integration.Tests.Helpers
{
    public class TestHelper
    {
        public HttpClient CreateClient()
        {
            return new WebApplicationFactory<Program>().CreateClient();
        }

        public StringContent CreateContent<T>(T entity)
        {
            return new StringContent(JsonConvert.SerializeObject(entity),
                Encoding.UTF8, "application/json");
        }
    }
}
