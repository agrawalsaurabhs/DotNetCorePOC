namespace DotNetCorePOC
{
    public class GreetingService : IGreetingService
    {
        public GreetingService()
        {
            Message = "Hello World!! from greeting service";
        }
        public string Message { get; }
    }
}