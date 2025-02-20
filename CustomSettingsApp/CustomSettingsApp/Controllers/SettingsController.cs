using CustomSettingsApp.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CustomSettingsApp.Controllers
{
    public class SettingsController : Controller
    {
        private readonly CustomSettings _customSettings;

        public SettingsController(IOptions<CustomSettings> customSettings)
        {
            _customSettings = customSettings.Value;
        }

        public IActionResult Index()
        {
            ViewBag.AppName = _customSettings.AppName;
            ViewBag.Version = _customSettings.Version;
            ViewBag.WelcomeMessage = _customSettings.WelcomeMessage;

            return View();
        }
    }
}
