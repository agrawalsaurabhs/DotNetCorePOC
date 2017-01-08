using DotNetCorePOC.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DotNetCorePOC.Services
{
    public class GreetingService : IGreetingService
    {
        public GreetingService(IConfiguration configuration)
        {
            Message = configuration["Greeting"];
        }
        public string Message { get; }
    }
}