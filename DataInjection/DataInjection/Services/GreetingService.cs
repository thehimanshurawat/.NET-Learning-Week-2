namespace DataInjection.Services
{
    public class GreetingService : IGreetingService
    {
        public string Greet(string name)
        {
            return $"Hello, {name}! Welcome to Dependency Injection in ASP.NET Core MVC.";
        }
    }
}
