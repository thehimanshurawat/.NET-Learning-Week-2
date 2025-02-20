using DataInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataInjection.Controllers
{
    public class GreetingController : Controller
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public IActionResult Index(string name = "Himanshu")
        {
            string message = _greetingService.Greet(name);
            return View("Greeting", message);
        }
    }
}
